
package solutions

import (
	"strings"
)

func ValidAnagramSolution(s string, t string) bool {

	if(len(s) != len(t)){ return false }

	for _, data := range s {
		if strings.Contains(t,string(data)){
			t = strings.Replace(t,string(data),"",1)
		}
	}

	if len(t) == 0 { return true}

	return false

}