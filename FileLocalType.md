# File Local Type

File Local type is a feature Introduced In C# 11
<details>
	<summary>Introduce the file modifier</summary>

``` c#
file class SqlDoc{
}
```
</details>

<details>
	<summary>Where can be used</summary>

### Only on a top level type
- class
- struct
- interface
- enum
- delegate
- record
- record struct
</details>

<details>
	<summary>Accessibility</summary>

- No accessibility modifier can be used with file on a type
- file is different different concept from accessibility ( can think of it as restriction of internal accessibility)
</details>

<details>
	<summary>Action allowed</summary>

- Can be used inside the same file [demo](./FileLocalTypesExample/SameFile.cs)
- Shadow the implementation of non-file-local type [demo](./FileLocalTypesExample/ShadowImplementation.cs)
- Can be attribute types of file-local and non-file-local types [demo](./FileLocalTypesExample/Attribute.cs)
- In terms of implementation and overrides have same behaviour of any other regular type [demo](./FileLocalTypesExample/ImplementationOverride.cs)

</details>

<details>
	<summary>Action not allowed</summary>

- File-local types are only visible inside the file where they are defined [demo](./FileLocalTypesExample/NotVisible.cs)
- If used for interfaces can't be implemented from non-file-local types [demo](./FileLocalTypesExample/NonFileLocalTypes.cs)
- If not used for interfaces can't extend non-file-local-types [demo](./FileLocalTypesExample/NonFileLocalTypes.cs)
- Can't be used in global using static [demo](./FileLocalTypesExample/GlobalUsingStatic.cs)
- Non-file-local types can't use file-local-type as signature [demo](./FileLocalTypesExample/SameFile.cs)

</details>

<details>
	<summary>Where to use it</summary>

- File-local types can contain implementation details that doesn't need to be shared from other part of the application [demo](./FileLocalTypesAsDto/Controllers/DbInstanceController.cs)
- Reduce the need for Source Generators to search for type names that wont collide

</details>
