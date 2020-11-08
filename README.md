# fsharp
This is a repository for the CSCI330: Programming Languages course. Our group is exploring F#.

## Documentation
Documentation can be found [here](https://fsharp.org/)

## Resources  
 - [Derek Banas: F# Tutorial](https://www.youtube.com/watch?v=c7eNDJN758U)  
   - Details syntax and provides lots of usage examples
 - [Introduction to F#](https://www.youtube.com/watch?v=n6giNJ4Wm6U)  
   - Good overview of what F# is
 - [What is .NET](https://dotnet.microsoft.com/learn/dotnet/what-is-dotnet)  
 - [Parallel and Asynchronous Programming with F#](https://www.youtube.com/watch?v=uyW4WZgwxJE)  
   - Primarily focuses on what F# can do, not too useful for syntax or details
 

### Compiling and Executing Code
If we have an example F# file `test.fsx`, then we would compile and run the file like this:  
```
$ dotnet fsi hello.fsx
```
#### Creating a Project from Terminal

If we want to create a project in a given directory, we run the following:  
```
$ dotnet new console --language F#
$ dotnet run
```

