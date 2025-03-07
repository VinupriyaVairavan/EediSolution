namespace API.Exceptions;

public class StudentNotFoundException(int id) : NotFoundException($"Student with id: {id} not found");