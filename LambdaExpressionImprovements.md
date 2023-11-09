# Lambda Expression Improvements

Lambda Expression is a short block of code that accepts parameters and returns a value.
```csharp
Func<int,int> Square = x => x * x;

Square(5); // 25
```

<details>
	<summary>Features</summary>

- Infer Natural delegate type for lambda and method groups
- Allow having attribute in lambdas
- Lambda with explicit Return type
</details>
<details>
	<summary>Infer natural delegate type</summary>

- Prior to c# 10 every time we define a delegate we need to specify explictly the delegate type [demo](./LambdaExpressionC9/NoNaturalType.cs)
- How much easier would be if we can just use var? [demo](./LambdaExpressionC10/WithNaturalTypeInferred.cs)
</details>
<details>
	<summary>Attributes on Lambda</summary>

- In version prior to c# 10, lambda didn't have the possibility to have attribute assigned to them [demo](./LambdaExpressionC9/NoAttribute.cs)
- From c# 10, attributes can be used with Lambdas as well providing parity with Methods and Local Functions [demo](./LambdaExpressionC10/WithAttribute.cs)

</details>
<details>
	<summary>Explicit return type</summary>

We can specify explicitly the return type of the lambda expression.

This feature can become interesting if the return type of the lambda expression can't be inferred because the lambda can return different type of results [demo](./LambdaExpressionC10/LambdaWithReturnTypes.cs)
</details>
<details>
	<summary>Motivation</summary>

All those improvement on lambda expression made easier the introduction of Minimal API!

Minimal Api are a Asp.net feature that allows the creation of endpoints with minimal dependencies.
Consider the following code using the classical API Controller [demo](./ApiWithController/Controllers/MonitoredEntitiesController.cs)

Now let's see how we can make the same with Minimal Api [demo](./MinimalApiExample/Program.cs)

</details>