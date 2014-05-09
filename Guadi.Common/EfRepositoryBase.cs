﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Guadi.Common.Tools;

namespace Guadi.Common.Data
{
    /// <summary>
    ///  EntityFramework仓储操作基类
    /// </summary>
    /// <typeparam name="TEntity">动态实体类型</typeparam>
    /// <typeparam name="TKey">实体主键类型</typeparam>
    public abstract class EfRepositoryBase<TEntity,TKey> : IRepository<TEntity,TKey> where TEntity : DataBase<TKey>
    {
        #region 属性

        /// <summary>
        /// 获取 仓储上下文的实例
        /// </summary>
        [Import]
        public IUnitOfWork UnitOfWork { get; set; }

        /// <summary>
        ///  获取 EntityFramework的数据仓储上下文
        /// </summary>
        protected UnitOfWorkContextBase EfContext
        {
            get
            {
                if (UnitOfWork is UnitOfWorkContextBase)
                {
                    return UnitOfWork as UnitOfWorkContextBase;
                }
                throw new DataAccessException(string.Format("数据仓储上下文对象类型不正确，应为UnitOfWorkContextBase,实际为{0}",UnitOfWork.GetType().Name));
            }
        }

        /// <summary>
        /// 当前实体的查询数据集
        /// </summary>
        public IQueryable<TEntity> Entities
        {
            get { return EfContext.Set<TEntity,TKey>(); }
        }

        #endregion

        #region 公共方法

        /// <summary>
        /// 插入实体记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="isSave">是否执行保存</param>
        /// <returns>操作影响的行数</returns>
        public virtual int Insert(TEntity entity, bool isSave = true)
        {
            EfContext.RegisterNew<TEntity,TKey>(entity);
            return isSave ? EfContext.Commit() : 0;
        }

        /// <summary>
        /// 批量插入实体记录
        /// </summary>
        /// <param name="entities">实体记录集合</param>
        /// <param name="isSave">是否执行保存</param>
        /// <returns>操作影响的行数</returns>
        public virtual int Insert(IEnumerable<TEntity> entities, bool isSave = true)
        {
            EfContext.RegisterNew<TEntity,TKey>(entities);
            return isSave ? EfContext.Commit() : 0;
        }

        /// <summary>
        /// 删除指定编号的记录
        /// </summary>
        /// <param name="id">实体记录编号</param>
        /// <param name="isSave">是否执行保存</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(TKey id, bool isSave = true)
        {
            TEntity entity = EfContext.Set<TEntity,TKey>().Find(id);
            return entity != null ? Delete(entity, isSave) : 0;
        }

        /// <summary>
        /// 删除实体记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="isSave">是否执行保存</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(TEntity entity, bool isSave = true)
        {
            EfContext.RegisterDeleted<TEntity,TKey>(entity);
            return isSave ? EfContext.Commit() : 0;
        }

        /// <summary>
        /// 删除实体记录集合
        /// </summary>
        /// <param name="entities">实体记录集合</param>
        /// <param name="isSave">是否执行保存</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(IEnumerable<TEntity> entities, bool isSave = true)
        {
            EfContext.RegisterDeleted<TEntity,TKey>(entities);
            return isSave?EfContext.Commit():0;
        }

        /// <summary>
        /// 删除所有符合特定表达式的数据
        /// </summary>
        /// <param name="predicate">查询条件谓语表达式</param>
        /// <param name="isSave">是否执行保存</param>
        /// <returns>操作影响的行数</returns>
        public int Delete(Expression<Func<TEntity, bool>> predicate, bool isSave = true)
        {
            List<TEntity> entities = EfContext.Set<TEntity,TKey>().Where(predicate).ToList();
            return entities.Count > 0 ? Delete(entities, isSave) : 0;
        }

        /// <summary>
        /// 更新实体记录
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="isSave">是否执行保存</param>
        /// <returns>操作影响的行数</returns>
        public int Update(TEntity entity, bool isSave = true)
        {
            EfContext.RegisterModified<TEntity,TKey>(entity);
            return isSave ? EfContext.Commit() : 0;
        }

        /// <summary>
        /// 使用附带新值的实体信息更新指定实体属性的值
        /// </summary>
        /// <param name="propertyExpression">属性表达式</param>
        /// <param name="entity">附带新值的实体信息，必须包含主键</param>
        /// <param name="isSave">是否执行保存</param>
        /// <returns>操作影响的行数</returns>
        public int Update(Expression<Func<TEntity, object>> propertyExpression, TEntity entity, bool isSave = true)
        {
            throw  new NotSupportedException("上下文公用，不支持按需更新功能");
        }

        /// <summary>
        /// 查找指定主键的实体记录
        /// </summary>
        /// <param name="key">指定主键</param>
        /// <returns>符合编号的记录，不存在返回null</returns>
        public TEntity GetByKey(TKey key)
        {
            return EfContext.Set<TEntity,TKey>().Find(key);
        }

        #endregion
    }
}
