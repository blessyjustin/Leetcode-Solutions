public class RandomizedSet {

    List<int> l;
    Random rand;
    public RandomizedSet() {
        l=new List<int>();
        rand=new Random();
    }
    
    public bool Insert(int val) {
        if(!l.Contains(val))
        {
            l.Add(val);
            return true;
        }
        else{
            return false;
        }
    }
    
    public bool Remove(int val) {
        if(l.Contains(val))
        {
            l.Remove(val);
            return true;
        }
        else{
            return false;
        }
    }
    
    public int GetRandom() {
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