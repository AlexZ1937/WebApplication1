using WebApplication1.Presenters.Results;

namespace WebApplication1.Presenters
{
    public interface IPresenter<T>
    {
        IResult GetResult();
        IResult GetResult(T requestData);
    }
}