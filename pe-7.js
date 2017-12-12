// warning: spams console with output due to brute force method. 

let primeCount = 1;

function primeCounter (n) {
  for (var counter = 2; primeCount <= n; counter++) {
    var not_prime = false;
    for (var div = 2; div <= (counter - 1); div++) {
      if (counter % div === 0) {
        not_prime = true;
      }
    }
    if (not_prime === false) {
      console.log(counter);
      primeCount ++;
    }
  }
}

primeCounter(10001);
// 104743
