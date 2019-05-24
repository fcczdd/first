using DTOModel;
using DTOModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseDAL<T> where T : BaseModel
    {
        private MyDbContext ctx;
        public BaseDAL(MyDbContext ctx)
        {
            this.ctx = ctx;
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> getAll()
        {
            return ctx.Set<T>().Where(e => e.is_delete == false);
        }
        /// <summary>
        /// 根据Id查询数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public T getById(long Id)
        {
            return ctx.Set<T>().Where(e => e.Id == Id && e.is_delete == false).SingleOrDefault();
        }
        /// <summary>
        /// 根据Id删除数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool deleteById(long Id)
        {
            T t = getById(Id);
            if (t != null)
            {
                //var ts=  t.ToList().FirstOrDefault();
                t.is_delete = false;
                ctx.Set<T>().Add(t);

            }
            return true;
        }
        /// <summary>
        /// 获取总条数
        /// </summary>
        /// <returns></returns>
        public int getTotalCount()
        {
            return getAll().Count();
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="start"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public IQueryable<T> getByPages(int start, int num)
        {
           return getAll().Skip(start).Take(num);
        }

    }
}
