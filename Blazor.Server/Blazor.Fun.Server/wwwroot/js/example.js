window.multiplyNumber = function(number) {
  return number * 2;  
};

window.multiplyByFive = function() {
  DotNet.invokeMethodAsync('Blazor.Fun.Server', 'MultiplyNumberByFive', 5).then(res => {
    alert(res);
  })
};