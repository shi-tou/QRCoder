QRCoder
=======

QRCoder 一个二维码生成工具。可根据二维码参数生成需要的二维码。

&cht=qr		类型为QR二维码

&chs=200×200	生成的图片尺寸 宽×高

&choe=UTF-8	这里是编码，这里默认UTF-8

&chl=XXXX	QR内容，也就是解码后看到的信息，这里长度最大2K，必须使用UTF-8编码

&chld=L|4	L代表默认纠错水平 ； 4代表二维码边界空白大小。纠错级别分为L、M、Q、H；

		L-默认：可以识别已损失的7%的数据
		
		M-可以识别已损失15%的数据
		
		Q-可以识别已损失25%的数据
		
		H-可以识别已损失30%的数据
		
