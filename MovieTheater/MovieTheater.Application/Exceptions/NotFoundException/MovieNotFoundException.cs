﻿namespace MovieTheater.Application.Exceptions.NotFoundException;

public class MovieNotFoundException: NotFoundException
{
    public MovieNotFoundException(Guid id): base($"Movie with id {id} was not found"){}
}