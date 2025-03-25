List<int> solution(List<int> nums1,List<int> nums2){

  var dataBag = <int,int>{};

  List<int> result = [];

  for(var num in nums1){
    dataBag[num] = num;
  }

  for(var num in nums2){
    if(dataBag.containsKey(num)){
      if(!result.contains(num)){
      result.add(num);
      }
    }
  }

  return result; 
}