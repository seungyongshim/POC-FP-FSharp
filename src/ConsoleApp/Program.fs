type todo =
| Incomplete of string
| Complete of string

let printTodo = function
| Incomplete x -> printfn $"Incompleted: {x}"
| Complete x -> printfn $"Completed: {x}"

let todoList =
  [
  Incomplete "Buy a coffee";
  Complete "Clean code"
  ]

todoList |> List.iter printTodo 

type Person =
  {
  First:string;
  Last:string
  }

type Employee =
| Worker of Person
| Manager of Employee list

let jdoe =
  {
  First="John";
  Last="Doe"
  }

let worker = Worker jdoe
