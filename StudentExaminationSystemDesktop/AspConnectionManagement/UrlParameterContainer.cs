using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspConnectionManagement
{
    public struct UrlParameterContainer
    {
        private Dictionary<string, object> parameters;

        public void AddParameter(string parameterName, object value, bool isArray)
        {
            if (parameters == null) parameters = new Dictionary<string, object>();

            if (isArray)
            {
                List<object> valuesArray = (List<object>)value;

                for (int i = 0; i < valuesArray.Count; i++)
                {
                    parameters.Add(parameterName, valuesArray[i]);
                }
            }

            else parameters.Add(parameterName, value);
        }

        public Dictionary<string, object> GetParameterList()
        {
             return parameters != null ? parameters : new Dictionary<string, object>();
        }
    }
}
