<?php

namespace Solutions;

class FindMissingAndRepeatedValues{


    public function solution($grid){
        $map = [];
        $result = [];

        for( $i = 1; $i <= (count($grid)*count($grid)); $i++ ){
            $map[$i] = 1; 
        } 

        foreach($grid as $oneDArray){
            foreach($oneDArray as $value){
                if(array_key_exists($value,$map)){
                    $map[$value]++;
                    if($map[$value] > 2) $result[] = $value;
                }
            }
        }

        foreach($map as $key => $value){
            if($value == 1){
                $result[] = $key;
            }
        }

        return $result;
    }
}