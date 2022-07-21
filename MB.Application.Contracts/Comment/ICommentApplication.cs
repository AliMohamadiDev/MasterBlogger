namespace MB.Application.Contracts.Comment;

public interface ICommentApplication
{
    List<CommentViewModel> GetList();
    void Add(AddComment command);
}