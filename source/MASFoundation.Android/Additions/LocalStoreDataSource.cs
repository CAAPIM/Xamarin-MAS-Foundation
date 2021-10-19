using System.Collections;

namespace Com.CA.Mas.Core.Datasource
{
  public partial class LocalStoreDataSource
  {
    IList IDataSource.GetKeys(Java.Lang.Object param)
    {
      return (IList) GetKeys(param);
    }
  }
}