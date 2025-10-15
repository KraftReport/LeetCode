<?php

namespace Solutions;

class FindMaximunNumberOfStringPairs{

    public function solution($words){
        $dictionary = array_count_values($words);
        var_dump($dictionary);
        $result = 0;
        foreach($words as $word){
            if(array_key_exists(strrev($word),$dictionary)){
                if($word === strrev($word)){

                }else{
                    if($dictionary[strrev($word)] ===  1){
                    var_dump($word);
                    $dictionary[$word]++;
                    $dictionary[strrev($word)]++;
                    $result++;
                }
                } 
            }
        }
        return $result;
    }
}