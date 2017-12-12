'use strict';
let numbers = [ ];
let sumOfSquare = 0;
let squareOfSum = 0;

function createArrayOfOneHundred() {
  for (let i = 0; i <100; i++) {
    numbers.push(i+1);
  }
  console.log(numbers);
}

function findSumOfSquare() {
  sumOfSquare = numbers.reduce((sum, num) => {
    sum = sum + Math.pow(num, 2);
    // console.log(num, sum);
    return sum;
  });
  console.log(sumOfSquare);
  return sumOfSquare;
}

function findSquareOfSum(){
  squareOfSum = Math.pow(numbers.reduce((sum, num) => {
    sum = sum + num;
    return sum;
  }), 2);
  console.log(squareOfSum);
  return squareOfSum;
}

function answer(a, b) {
  return a - b;
}

createArrayOfOneHundred();
findSumOfSquare();
findSquareOfSum();
console.log(answer(squareOfSum, sumOfSquare)); // 25164150
