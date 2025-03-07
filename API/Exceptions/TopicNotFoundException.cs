namespace API.Exceptions;

public class TopicNotFoundException(int id) : NotFoundException($"Topic with id : {id} not found");