using YR.FrameWork.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yale.Model;

namespace Yale.DAL
{
    public class RecipeService : BaseService<RecipeEntity>, IScopedSelfDependency
    {

    }
}
