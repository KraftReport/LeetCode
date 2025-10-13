<?php

namespace Solutions;

class OrderedStream {
 
    private array $stream;
    private int $pointer;
    private int $n;
    function __construct(int $n) {
        $this->stream = array_fill(0,$n,null);
        $this->pointer = 1;
        $this->n = $n;
    }
 
    function insert(int $idKey,string $value) {
        $this->stream[$idKey-1] = $value;

        $chunk = [];

        if($idKey == $this->pointer){
            while($this->pointer <= $this->n && $this->stream[$this->pointer-1] !== null){
                $chunk[] = $this->stream[$this->pointer-1];
                $this->pointer++;
            }
        }

        return $chunk;
    }
}