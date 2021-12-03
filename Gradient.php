/*
This shit was never tested to report bugs!
*/


<?php

class Occupieds_Sexy_Gradient_Script {
	public $startrgb;
	public $endrgb;
	public $text;

	function __construct($startrgb, $endrgb) {
		$this->startrgb = $startrgb;
		$this->endrgb = $endrgb;
		$this->text = $text
	}

	public change_color($startrgb, $endrgb) {
		$this->startrgb = $startrgb;
		$this->endrgb = $endrgb;
	}

	public function gradient(text) {
		$change_r = int(endrgb[0]) - int(startrgb[0]) / strlen(text);
		$change_g = int(endrgb[0]) - int(startrgb[0]) / strlen(text);
		$change_b = int(endrgb[0]) - int(startrgb[0]) / strlen(text);

		$r = int(startrgb[0]);
		$g = int(startrgb[1]);
		$b = int(startrgb[2]);

		$grad_text;
		for($i = 0; i <= strlen(text); $i++) {
			if(text[$i] == "\n") {
				$grad_text += "\n";
				continue;
			}
			grad_text += "\x1b[38;2;". $r. ";". $g. ";". $b. "m". $text[$i];
			$r += $change_r;
			$g += $change_g;
			$b += $change_b;
		}
		echo $grad_text. "\x1b[39m";
	}
}
