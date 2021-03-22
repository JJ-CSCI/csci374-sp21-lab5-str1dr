module Assignment

type Tree =
    | Node of Tree * Tree
    | Leaf of int

let rec prod (t:Tree) :int =
  let (a,b)
  match t with
    | Leaf a -> a // a is int type
    | Node (a,b) -> a * b // but a & b now of Tree type so use recursion to process them.
    
    | _ -> 0

// Tuple denifed as comma separated values
// (a,b) is a tuple

let rec map (f:int->int) (t:Tree) :Tree =
    | 

let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""
