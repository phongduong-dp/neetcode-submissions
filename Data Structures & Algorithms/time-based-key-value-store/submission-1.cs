public class TimeMap {

    private Dictionary<string,List<Tuple<int,string>>> m;

    public TimeMap() {
        m = new Dictionary<string,List<Tuple<int,string>>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!m.ContainsKey(key)){
            m[key] = new List<Tuple<int,string>>();
        }
        m[key].Add(new Tuple<int,string>(timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if (!m.ContainsKey(key)) return "";

        var valueList = m[key];
        var l = 0;
        var r = valueList.Count - 1;
        var result = "";

        while (l <= r){
            var mid = (l + r) / 2;

            if (valueList[mid].Item1 <= timestamp) {
                result = valueList[mid].Item2;
                l = mid + 1;
            }else{
                r = mid - 1;
            }

        }

        return result;


    }
}
