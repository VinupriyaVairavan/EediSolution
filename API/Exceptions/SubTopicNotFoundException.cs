namespace API.Exceptions;

public class SubTopicNotFoundException(int id) : NotFoundException($"Subtopic with id : {id} not found");