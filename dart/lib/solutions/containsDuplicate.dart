bool? solution(List<int> nums,int k){

  var dataBag = <int,List<int>>{};
  var result = false;

  for(int i = 0; i< nums.length; i++){
    if(dataBag.containsKey(nums[i])){
      dataBag[nums[i]]?.add(i);
    }else{
      dataBag[nums[i]] = [i];
    }
  }

  for (var data in dataBag.values) {
    print(data);
  }
 
  for(var list in dataBag.values){
      if(list.length>=2){
        list.sort();
        var left = 0; var right = 1;
        while(right<list.length){
          if((list[right]-list[left]).abs()<=k){
            result = true;
            return result;
          }
          right++;
          if(right==list.length){
            left++;
            right = left+1;
          }
        }
      }
  }
  return result;
}