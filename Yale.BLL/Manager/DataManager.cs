using AngleSharp.Dom;
using YR.FrameWork.DependencyInjection;
using Mapster;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yale.DAL;
using Yale.Helper;
using Yale.Model;

namespace Yale.BLL
{
    public class DataManager : IScopedSelfDependency
    {
        private readonly DataService _dataService;
        public DataManager(DataService dataService)
        {
            _dataService = dataService;
        }

        public async Task<BaseResult> AddDataAsync(AddDataDto request)
        {
            var entity = request.Adapt<DataEntity>();
            var res = await _dataService.InsertAsync(entity);

            if (res > 0)
            {
                return new BaseResult() { Status = SystemEnums.Result.Success };
            }

            return new BaseResult() { Status = SystemEnums.Result.Fail, Msg = "添加数据失败" };
        }

        public async Task<BaseResult<QueryDataResultDto>> GetDataListByTimeAsync(QueryDataDto request)
        {
            var res = await _dataService.GetListAsync(c => SqlFunc.Between(c.InsertTime, request.StartTime, request.EndTime));

            return new BaseResult<QueryDataResultDto>() { Status = SystemEnums.Result.Success, Data = res.Adapt<List<QueryDataResultDto>>() };

        }
    }
}
