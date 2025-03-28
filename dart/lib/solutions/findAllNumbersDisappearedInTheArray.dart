List<int> solution(List<int> nums){
  var dataBag = <int>{};
  nums.sort();
  var largest = nums.length;
  print(largest);
  var smallest = 1;
  dataBag.add(smallest);
  while(smallest<largest){
    smallest++;
    var number = smallest;
    dataBag.add(number);
  }
  print(dataBag);
  for(var num in nums){
    if(dataBag.contains(num)){
      dataBag.remove(num);
    }
  }
  return dataBag.toList();
}