<?php

namespace Solutions;

class MaximunNumbersOfWordsYouCanType{

    public function solution($text,$brokenLetters){
         
        $array = explode(" ", $text);
        $brokenArray = str_split($brokenLetters);
        $result = count($array);
        
        foreach($array as $word){
           foreach($brokenArray as $broken){
            if(str_contains($word, $broken)){
                $result--;
                continue 2;
            }
           }
        }
        
        return $result;
    }

}