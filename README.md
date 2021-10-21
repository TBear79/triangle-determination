# triangle-determination
Test program that determines the type of triangle


## Considerations

Developed in dotnet CORE using VSCode (My preferred editor)

I didn't see the need for a sln-file for this tiny program, also I didn't put the logic in a separate class-library.

Since the logic doesn't depend on any sub-classes or database dependencies, I haven't made dependency injection.

The logic for determining the type of triangle is done using TDD where as the shell for the program is not tested. Thats because I'd have to mock out console writes... and that would require googling :-)

## Run Program

Well, if it where a real program I'd Dockerize it, but now just go to the /Program folder and write
```
dotnet run
```

## Run Tests
```
dotnet test Tests/TriangleDetermination.Test.csproj
```