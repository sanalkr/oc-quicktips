

namespace CSharpTips.Console
{

    public class AvoidTemporaryCollection
    {
        private IEnumerable<int> _temporaryCollection = Enumerable.Range(50, 100);   
    

        public IEnumerable<int> GetValuesAboveHundredWithTempCollection()
        {
            List<int> tempCollection = new List<int>();

            foreach (var item in _temporaryCollection)
            {
                if(item > 100)
                    tempCollection.Add(item);
            }
 
            return tempCollection;
        }

        public IEnumerable<int> GetValuesAboveHundred()
        {
            foreach (var item in _temporaryCollection)
            {
                if (item > 100)
                    yield return item;
            }
        }
    }
}
