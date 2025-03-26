List<int> solution(List<int> nums1,List<int> nums2){
 
  List<int> result =  [];
 
  var dataList = List.from(nums1);

  for(var num in dataList){
    if(nums1.contains(num) && nums2.contains(num)){
      result.add(num);
      nums1.remove(num);
      nums2.remove(num);
    }
  }

  return result;
}