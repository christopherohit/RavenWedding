using System;
using System.Collections.Generic;
using System.Text;
using Telerik.Data.Expressions;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.Expressions
{
    public class CustomExpressionContext : ExpressionContext
    {
        /// <summary>
        /// Custom function, which returns Pi.
        /// </summary>
        /// <returns></returns>
        public double Pi()
        {
            return Math.PI;
        }
    }
}
