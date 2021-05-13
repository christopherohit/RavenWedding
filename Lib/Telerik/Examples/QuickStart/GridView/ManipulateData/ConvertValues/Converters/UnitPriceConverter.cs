using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using Microsoft.CSharp;

namespace Telerik.Examples.WinControls.GridView.ManipulateData.ConvertValues
{
    public class UnitPriceConverter : TypeConverter
    {
        #region Static Fields

        private static readonly string ClassTemplate = "using System; " +
                                                       "public class DynamicUnitPriceExpression: {0}.IUnitPriceExpression " +
                                                       "{{ " +
                                                       "       public double Evaluate(double price) " +
                                                       "       {{" +
                                                       "            return Convert.ToDouble({1});" +
                                                       "       }}" +
                                                       "}}";

        #endregion

        #region Nested Types

        public interface IUnitPriceExpression
        {
            double Evaluate(double price);
        }

        #endregion

        #region Fields

        private IUnitPriceExpression expression = null;

        #endregion

        #region Properties

        public CompilerErrorCollection SetExpression(string expression)
        {
            CompilerErrorCollection compilerErrors = new CompilerErrorCollection();

            IUnitPriceExpression newExpression = CreateDynamicExpression(expression, out compilerErrors);

            if (!compilerErrors.HasErrors)
            {
                this.expression = newExpression;
            }

            return compilerErrors;
        }

        #endregion

        #region Dynamic Expression Creation

        private static IUnitPriceExpression CreateDynamicExpression(string expression, out CompilerErrorCollection errors)
        {
            errors = new CompilerErrorCollection();

            if (String.IsNullOrEmpty(expression))
            {
                return null;
            }

            CompilerParameters parms = new CompilerParameters();

            parms.GenerateExecutable = false;
            parms.GenerateInMemory = true;
            parms.IncludeDebugInformation = false;

            string assemblyFileName = Path.GetFileName(Assembly.GetExecutingAssembly().Location);
            parms.ReferencedAssemblies.Add("System.dll");
            parms.ReferencedAssemblies.Add(assemblyFileName);

            CodeDomProvider compiler = CSharpCodeProvider.CreateProvider("CSharp");
            string classCode = string.Format(ClassTemplate, typeof(UnitPriceConverter).FullName, expression);

            CompilerResults compilerResults = compiler.CompileAssemblyFromSource(parms, classCode);

            if (compilerResults.Errors.HasErrors)
            {
                errors = compilerResults.Errors;
                return null;
            }

            Assembly assembly = compilerResults.CompiledAssembly;
            IUnitPriceExpression unitPriceExpression = assembly.CreateInstance("DynamicUnitPriceExpression") as IUnitPriceExpression;
            return unitPriceExpression;
        }

        #endregion

        #region Convert To Methods

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(double) || destinationType == typeof(decimal);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value == null)
            {
                if (destinationType == typeof(double))
                {
                    return 0D;
                }

                return 0M;
            }

            double doubleValue = Convert.ToDouble(value);

            if (this.expression != null)
            {
                doubleValue = this.expression.Evaluate(doubleValue);
            }

            if (destinationType == typeof(decimal))
            {
                return Convert.ToDecimal(doubleValue);
            }

            return doubleValue;
        }

        #endregion

        #region Convert From Methods

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(decimal);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value == null)
            {
                return 0D;
            }

            decimal decimalValue = (decimal)value;
            return Convert.ToDouble(decimalValue);
        }

        #endregion
    }
}
