// Brute Force - for the love of all that is holy do not try and run this. 
// Work in Progress

let a = 1;
let b = 1;
var c = 0;

function fib(){
  for (let i = 1; c.toString().length <= 999; i++){
    c = a + b;
    a = b;
    b = c;
  }
  console.log(c);
}

fib();
