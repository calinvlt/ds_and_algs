namespace Heaps;

public class Heap<T> where T: IComparable {
  
  List<T> data;
  
  public Heap()
  {
    data = new List<T>();
  }

  public T? GetRoot() {
    return data.FirstOrDefault();
  }

  public T? Last() {
    return data.LastOrDefault();
  }

  public T? GetLeft(int index) {
    int leftIndex = (2 * index) + 1;
    return leftIndex < data.Count ? data[leftIndex] : default(T);
  }

  public T? GetRight(int index) {
    int rightIndex = (2 * index) + 2;
    return rightIndex < data.Count ? data[rightIndex] : default(T);
  }

  public T? GetParent(int index) {
    int parentIndex = (index - 1) / 2;
    return parentIndex >= 0 ? data[parentIndex] : default(T);
  }

  public void Insert(T value) {
    data.Add(value);

    var index = data.Count() - 1;
    T? parent = default(T);
    
    while ((parent = GetParent(index)) != null) {
      if (parent.CompareTo(value) < 0) {
        int parentIndex = (index - 1) / 2;        
        data[parentIndex] = value;
        data[index] = parent;
        index = parentIndex;
      } else {
        break;
      }
    }
  }

  public T? Delete() {
    if (data.Count == 0) return default(T);

    var r = data[0];
    if (data.Count == 1) {      
      data.Remove(r);
      return r;
    }
    
    data[0] = data.Last();
    data.Remove(data.Last());
    
    int index = 0;
    while(index < data.Count) {
      var leftIndex = (2 * index) + 1;
      var rightIndex = (2 * index) + 2;
      
      if (data[index].CompareTo(data[leftIndex]) >= 0 && data[index].CompareTo(data[rightIndex]) >= 0) break;

      int newIndex = -1;
      if (data[leftIndex].CompareTo(data[rightIndex]) >= 0) {newIndex = leftIndex;} 
      else {newIndex = rightIndex; }

      var t = data[newIndex];
      data[newIndex] = data[index];
      data[index] = t;
      
      index = newIndex;
    }
    return r;
  }

  public override string ToString()
  {    
    return string.Join(',', data.ToArray());
  }
}