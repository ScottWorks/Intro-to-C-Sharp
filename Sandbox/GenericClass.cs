namespace Sandbox
{
  public class GenericClass<T>
  {
    public GenericClass()
    {
      // this.Result = null;
      // this.Message = null;
    }
    public GenericClass(T result, string message) : this()
    {
      this.Result = result;
      this.Message = message;
    }

    public T Result { get; set; }
    public string Message { get; set; }
  }
}