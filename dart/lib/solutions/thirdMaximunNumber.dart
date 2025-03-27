int solution(List<int> nums){
  nums.sort();
  var maxToMin = nums.reversed.toList();
  var set = maxToMin.toSet();
  var dataList = set.toList(); 
  if(dataList.length<3){
    print(dataList.length);
    return dataList[0];
  }
  return dataList[2];
}