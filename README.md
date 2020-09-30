# RestCalculator

Rest service for Calculator using .NET Core 3.1

## Steps

Build and run locally:

```
cd ./RestCalculator.API
dotnet clean
dotnet watch run
```

Swagger UI at https://localhost:5001/swagger/index.html

## API endpoints

- Get /api/v1.0/Calculator/Add/?num1=1&num2=2
- Get /api/v1.0/Calculator/Sub/?num1=1&num2=2
- Get /api/v1.0/Calculator/Multiple/?num1=1&num2=2
- Get /api/v1.0/Calculator/Divide/?num1=1&num2=2

## Todo

- Unit Test
- Precision control (Tried NumEval, not compatiable with .NET Core)
