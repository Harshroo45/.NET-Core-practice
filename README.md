# .NET Core LINQ Practice Repository

A comprehensive learning repository covering **beginner to advanced level LINQ** concepts and coding examples in C# with .NET Core.

## 📚 Overview

This repository contains a collection of LINQ (Language Integrated Query) examples, exercises, and best practices. Whether you're just starting with LINQ or looking to master advanced techniques, you'll find practical examples and explanations here.

## 🎯 Learning Levels

### Beginner Level
- Basic LINQ syntax and method chains
- Simple filtering, selecting, and ordering
- Working with IEnumerable and collections
- Introduction to query expressions vs method syntax
- Common LINQ operators (Where, Select, OrderBy, etc.)

### Intermediate Level
- Grouping and aggregation operations
- Join operations (inner, outer, cross joins)
- LINQ to Objects advanced patterns
- Performance considerations
- Working with multiple data sources
- Set operations (Union, Intersect, Except)

### Advanced Level
- Custom LINQ extensions
- Expression trees
- LINQ to SQL/Entity Framework techniques
- Deferred execution and lazy evaluation
- Parallel LINQ (PLINQ)
- Complex query optimization
- Advanced projection patterns

## 📁 Repository Structure

```
.NET-Core-practice/
├── Beginner/
│   ├── BasicFiltering.cs
│   ├── BasicSelection.cs
│   ├── BasicOrdering.cs
│   └── ...
├── Intermediate/
│   ├── Grouping.cs
│   ├── Joins.cs
│   ├── Aggregations.cs
│   └── ...
├── Advanced/
│   ├── ExpressionTrees.cs
│   ├── PLINQ.cs
│   ├── CustomExtensions.cs
│   └── ...
└── README.md
```

## 🚀 Getting Started

### Prerequisites
- .NET Core SDK 6.0 or higher
- C# 9.0 or higher
- A code editor (Visual Studio, VS Code, Rider, etc.)

### Installation

1. Clone the repository:
```bash
git clone https://github.com/Harshroo45/.NET-Core-practice.git
cd .NET-Core-practice
```

2. Open the solution in your preferred IDE:
```bash
dotnet open
# or
code .
```

3. Build the project:
```bash
dotnet build
```

## 💡 Key Topics Covered

### Filtering & Selection
- `Where()` - Filter elements based on conditions
- `Select()` - Transform elements
- `SelectMany()` - Flatten nested collections
- `Distinct()` - Remove duplicates
- `Skip()` & `Take()` - Pagination

### Ordering & Grouping
- `OrderBy()` & `OrderByDescending()` - Sort elements
- `ThenBy()` - Secondary sorting
- `GroupBy()` - Group elements by key
- `Reverse()` - Reverse order

### Aggregation
- `Count()` - Element count
- `Sum()`, `Average()`, `Min()`, `Max()` - Numeric operations
- `Aggregate()` - Custom aggregation
- `First()`, `Last()`, `Single()` - Element retrieval

### Joins & Set Operations
- `Join()` - Inner join
- `GroupJoin()` - Left join
- `Union()` - Combine collections
- `Intersect()` - Common elements
- `Except()` - Difference between collections

### Advanced Topics
- **Expression Trees** - Build queries dynamically
- **PLINQ** - Parallel query execution
- **Deferred Execution** - Understand when queries execute
- **Query Optimization** - Performance best practices

## 📖 Usage Examples

### Beginner Example
```csharp
// Filter numbers greater than 5
var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var result = numbers.Where(n => n > 5).OrderBy(n => n);
// Result: { 6, 7, 8, 9, 10 }
```

### Intermediate Example
```csharp
// Group employees by department and get average salary
var avgSalaryByDept = employees
    .GroupBy(e => e.Department)
    .Select(g => new 
    { 
        Department = g.Key, 
        AvgSalary = g.Average(e => e.Salary) 
    });
```

### Advanced Example
```csharp
// Using expression trees for dynamic filtering
Expression<Func<Employee, bool>> predicate = e => e.Salary > 50000;
var result = employees.AsQueryable().Where(predicate).ToList();
```

## 🎓 Learning Path

1. **Start here**: Begin with the Beginner level examples
2. **Practice**: Complete the exercises in each section
3. **Experiment**: Modify examples to understand behavior
4. **Progress**: Move to Intermediate level once comfortable
5. **Master**: Tackle Advanced topics and optimization techniques

## 📝 Contributing

Feel free to contribute by:
- Adding new examples
- Improving existing code
- Fixing bugs or typos
- Adding documentation
- Suggesting enhancements

Please follow the existing code style and add comments to your examples.

## 🔗 Resources

- [Microsoft LINQ Documentation](https://docs.microsoft.com/dotnet/csharp/linq/)
- [LINQ Query Syntax](https://docs.microsoft.com/dotnet/csharp/programming-guide/concepts/linq/query-syntax-and-method-syntax-in-linq)
- [Entity Framework Core](https://docs.microsoft.com/ef/core/)
- [C# Language Features](https://docs.microsoft.com/dotnet/csharp/)

## 📄 License

This repository is open source and available under the [MIT License](LICENSE).

## 👤 Author

**Harshroo45**

## 📞 Support

If you have questions or need clarification on any topic:
- Open an issue in the repository
- Check existing documentation
- Review the code comments and examples

---

**Happy Learning!** 🎉

Start with the Beginner examples and work your way up. Remember: practice makes perfect!
