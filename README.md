# BadPassword
Check a string against a compiled index of common passwords. This project relies on the [bad-passwords-index project by robsheldon](https://github.com/robsheldon/bad-passwords-index).

# NuGet
```
Install-Package BadPassword
```

# Usage

```cs
"password".IsBadPassword()    // returns true

"iRHaluzn".IsBadPassword()    // returns false
```