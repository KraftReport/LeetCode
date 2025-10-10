<?php

namespace Solutions;

class CheckIfPangram{
    
    public function solution($sentence){

        $map = [];
        $count = 0;

        foreach(str_split($sentence) as $key){
            if(!in_array($key,$map)){
                $map[] = $key;
                $count++;
            }
        } 

        return $count === 26 ;
    }
}