List<String>? solution(List<int> nums){
 
  if (nums.isEmpty) return [];

  var dataBag = <List<int>>[];

  var dataList = <int>[nums[0]]; 

  var result = <String>[];

  for(var i = 1 ; i< nums.length ; i++){
    if(nums[i]==nums[i-1]+1){
      
      dataList.add(nums[i]);
       
    }else{
      dataBag.add(List.from(dataList));
      dataList = [nums[i]];
    } 
  }

  dataBag.add(List.from(dataList));

  for(var data in dataBag){
    
    if(data.length ==1){
      result.add("${data[0]}");
    }else{
      result.add("${data[0]}->${data[data.length-1]}");
    }

  }

  return result;
}