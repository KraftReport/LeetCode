<?php
namespace Solutions;
class FindCommonElementBetweenTwoArrays{

    public function solution($num1, $num2){
        $result = [];
        $num1Result = 0;
        $num2Result = 0;
        $num1Set = array_unique($num1);
        $num2Set = array_unique($num2);

        foreach($num1 as $num){
            if(in_array($num,$num2Set)){
                $num1Result++;
            }
        }

        $result[] = $num1Result;

        foreach($num2 as $num){
            if(in_array($num,$num1Set)){
                $num2Result++;
            }
        }

        $result[] = $num2Result;

        return $result;
    }
}