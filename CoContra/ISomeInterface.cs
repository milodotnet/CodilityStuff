namespace CoContra
{
    public interface ISomeInterface<out T1, in T2>
    {
        T1 SomeMethod(T2 someParam);
        // can't since it violates the rules for covariance
        //T2 SomeMethod(T1 soeparam);
    }
}