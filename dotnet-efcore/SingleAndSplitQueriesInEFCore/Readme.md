 * Summary 
```sh
BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4355/22H2/2022Update)
Intel Core i7-2600S CPU 2.80GHz (Sandy Bridge), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.300
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX
  Job-CIANGN : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX

IterationCount=100

| Method                                                 | Mean      | Error    | Median    | Gen0       | Gen1     | Allocated |
|------------------------------------------------------- |----------:|---------:|----------:|-----------:|---------:|----------:|
| GetCompaniesWithDepartmentsUsingSingleQuery            |  26.32 ms | 0.226 ms |  26.28 ms |  1000.0000 |        - |   4.04 MB |
| GetCompaniesWithDepartmentsAndProductsUsingSingleQuery | 359.26 ms | 1.912 ms | 358.90 ms | 11000.0000 |        - |  46.93 MB |
| GetCompaniesWithDepartmentsUsingSplitQuery             |  26.65 ms | 0.400 ms |  26.49 ms |   687.5000 | 312.5000 |   4.25 MB |
| GetCompaniesWithDepartmentsAndProductsUsingSplitQuery  |  49.15 ms | 0.453 ms |  48.77 ms |  1200.0000 | 400.0000 |   8.36 MB |
```
