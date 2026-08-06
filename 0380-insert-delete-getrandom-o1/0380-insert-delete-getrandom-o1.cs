public class RandomizedSet {

    List<int> l;
    Dictionary <int,int> dict;
    Random rand;
    public RandomizedSet() {
        l=new List<int>();
        dict=new Dictionary<int,int>();
        rand=new Random();
    }
    
    public bool Insert(int val) 
    {
        if(dict.ContainsKey(val))
        {
            return false;
        }
        l.Add(val);
        dict[val]=l.Count-1;
        return true;
       
    }
    
    public bool Remove(int val) 
    {
        if(!dict.ContainsKey(val))
        {
            return false;
        }
        int i=dict[val];
        int lastele=l[l.Count-1];
        l[i]=lastele;
        dict[lastele]=i;
        l.RemoveAt(l.Count-1);
        dict.Remove(val);
        return true;
        
    }
    
    public int GetRandom() 
    {
        int i=rand.Next(l.Count);
        return l[i];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */