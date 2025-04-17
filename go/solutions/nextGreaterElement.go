package solutions 
 
import "fmt"

func NextGreaterElement(nums1 []int,nums2 []int)[]int{
	for i := 0 ; i < len(nums1); i++ {
		// fmt.Println(nums1[i])
		index := 0
		for x, num := range nums2{
			if nums1[i] == num {
				index = x
			}
		} 
		if(index == len(nums2)-1){
			nums1[i] = -1
		}else{
			mark := false
			for j := index ; j < len(nums2) -1; j++{
				if(nums2[j+1] > nums1[i] && mark == false ){
					fmt.Println(nums1[i])
					nums1[i] = nums2[j+1]
					mark = true
				}  
			}
			if(mark == false){
				nums1[i] = -1
			}
		}
	}
	return nums1
}