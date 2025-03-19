int? solution(List<int> nums){

  var dataBag = <int,int>{};

  for(var num in nums){
      
      if(dataBag.containsKey(num)){
      
        dataBag.remove(num); 
      
      }else{
      
        dataBag.addAll({num : 1}); 
      
      }
  }

  return dataBag.keys.first;

}