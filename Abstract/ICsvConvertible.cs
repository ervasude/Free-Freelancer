using System;
namespace Free_Freelancer.Abstract
{
	internal interface ICsvConvertible
	{
        string GetValuesCSV();
        void SetValuesCSV(string csv);
    }
}

