using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Neo4J
{
    public class PredicateRewriter
    {
        public static Expression<Func<TEntity, bool>> Rewrite<TEntity>(Expression<Func<TEntity, bool>> exp, string newParamName)
        {
            ParameterExpression param = Expression.Parameter(exp.Parameters[0].Type, newParamName);
            Expression newExpression = new PredicateRewriterVisitor(param).Visit(exp);

            return (Expression<Func<TEntity, bool>>)newExpression;
        }

        private class PredicateRewriterVisitor : ExpressionVisitor
        {
            private readonly ParameterExpression _parameterExpression;

            public PredicateRewriterVisitor(ParameterExpression parameterExpression)
            {
                _parameterExpression = parameterExpression;
            }

            protected override Expression VisitParameter(ParameterExpression node)
            {
                return _parameterExpression;
            }
        }
    }
}
