//Maya ASCII 2013 scene
//Name: msh_ground.ma
//Last modified: Sun, Jun 23, 2013 12:12:57 AM
//Codeset: 1252
requires maya "2013";
requires "stereoCamera" "10.0";
currentUnit -l centimeter -a degree -t pal;
fileInfo "application" "maya";
fileInfo "product" "Maya 2013";
fileInfo "version" "2013 x64";
fileInfo "cutIdentifier" "201202220241-825136";
fileInfo "osv" "Microsoft Windows 7 Business Edition, 64-bit Windows 7 Service Pack 1 (Build 7601)\n";
createNode transform -n "grp_ground";
	setAttr ".t" -type "double3" 0 -0.12538245233253423 0 ;
	setAttr ".rp" -type "double3" -1.1920928955078125e-007 0.12538245233253423 4.4408920985006262e-016 ;
	setAttr ".sp" -type "double3" -1.1920928955078125e-007 0.12538245233253423 4.4408920985006262e-016 ;
createNode transform -n "msh_cube_base21" -p "grp_ground";
	setAttr ".t" -type "double3" -5 -0.068847642219505872 4.9999999999999982 ;
	setAttr ".rp" -type "double3" 1.05886602400094 0.072057360490091565 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 1.05886602400094 0.072057360490091565 -2.384185791015625e-007 ;
createNode mesh -n "msh_cube_base21Shape" -p "msh_cube_base21";
	setAttr -k off ".v";
	setAttr -s 25 ".iog";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 24 ".uvst[0].uvsp[0:23]" -type "float2" 0 0.97990215 0.019593954
		 0.9993968 0.98040569 0.99899256 0.99999988 0.97939837 0.99999988 0.020601511 0.98040569
		 0.0010073185 0.019593716 0.00060319901 0 0.020097733 0 0.020097733 0 0.97990215 0.019593716
		 0.00060319901 0.98040569 0.0010073185 0.99999988 0.020601511 0.99999988 0.97939837
		 0.98040569 0.99899256 0.019593954 0.9993968 0.034715652 0.020022869 0.96527183 0.020414352
		 0.98056591 0.035708189 0.98056591 0.96429181 0.96527183 0.97958565 0.034715891 0.97997713
		 0.019433975 0.96477282 0.019433975 0.03522706;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".lev" 1;
	setAttr -s 24 ".vt[0:23]"  1.20101452 0.14676766 -1.24748182 1.25 0.14676766 -1.19849634
		 1.20101452 0.1467678 1.24748135 1.25 0.1467678 1.19849586 -1.20101547 0.14676766 1.24849176
		 -1.25 0.14676768 1.19975519 -1.201015 0.1467678 -1.24849224 -1.24999952 0.1467678 -1.19975567
		 -1.20141506 0.27992216 1.16193199 -1.25 0.22507176 1.19975519 -1.20141459 0.27992228 -1.16193247
		 -1.24999952 0.22507188 -1.19975567 -1.16321087 0.27992213 1.19994259 -1.20101547 0.22507174 1.24849176
		 1.16317987 0.27992228 1.19896412 1.20101452 0.22507188 1.24748135 1.20141506 0.27992228 1.16072941
		 1.25 0.22507188 1.19849586 1.20141506 0.27992213 -1.16072989 1.25 0.22507174 -1.19849634
		 1.16317987 0.27992213 -1.1989646 1.20101452 0.22507174 -1.24748182 -1.16320992 0.27992228 -1.1999433
		 -1.201015 0.22507188 -1.24849224;
	setAttr -s 40 ".ed[0:39]"  1 3 0 1 0 0 2 4 0 2 3 0 5 7 0 5 4 0 6 0 0
		 6 7 0 5 9 0 7 11 0 4 13 0 2 15 0 3 17 0 1 19 0 0 21 0 6 23 0 12 14 0 14 16 0 16 18 0
		 18 20 0 20 22 0 22 10 0 10 8 0 8 12 0 9 11 0 11 23 0 13 9 0 15 13 0 17 15 0 19 17 0
		 21 19 0 23 21 0 8 9 0 13 12 0 10 11 0 22 23 0 15 14 0 17 16 0 19 18 0 21 20 0;
	setAttr -s 18 -ch 80 ".fc[0:17]" -type "polyFaces" 
		f 8 -8 6 -2 0 -4 2 -6 4
		mu 0 8 0 1 2 3 4 5 6 7
		f 4 -5 8 24 -10
		mu 0 4 0 7 8 9
		f 4 5 10 26 -9
		mu 0 4 7 6 10 8
		f 4 -3 11 27 -11
		mu 0 4 6 5 11 10
		f 4 3 12 28 -12
		mu 0 4 5 4 12 11
		f 4 -1 13 29 -13
		mu 0 4 4 3 13 12
		f 4 1 14 30 -14
		mu 0 4 3 2 14 13
		f 4 -7 15 31 -15
		mu 0 4 2 1 15 14
		f 4 7 9 25 -16
		mu 0 4 1 0 9 15
		f 8 16 17 18 19 20 21 22 23
		mu 0 8 16 17 18 19 20 21 22 23
		f 4 32 -27 33 -24
		mu 0 4 23 8 10 16
		f 4 -33 -23 34 -25
		mu 0 4 8 23 22 9
		f 4 -35 -22 35 -26
		mu 0 4 9 22 21 15
		f 4 -34 -28 36 -17
		mu 0 4 16 10 11 17
		f 4 -37 -29 37 -18
		mu 0 4 17 11 12 18
		f 4 -38 -30 38 -19
		mu 0 4 18 12 13 19
		f 4 -39 -31 39 -20
		mu 0 4 19 13 14 20
		f 4 -40 -32 -36 -21
		mu 0 4 20 14 15 21;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ns" 0.04;
	setAttr ".dr" 1;
createNode mesh -n "polySurfaceShape2" -p "msh_cube_base21";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".iog[0].og[0].gcl" -type "componentList" 1 "f[0]";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 8 ".uvst[0].uvsp[0:7]" -type "float2" 0.37500003 0.48751006
		 0.375 0.48769361 0.39971158 0.5 0.39971125 0.5 0.375 0.48763102 0.39971161 0.5 0.375
		 0.48757386 0.39971125 0.5;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".lev" 1;
	setAttr -s 8 ".vt[0:7]"  1.20101488 0.14676766 -1.2474817 1.25000012 0.14676766 -1.19849646
		 1.20101452 0.1467678 1.24748135 1.24999976 0.1467678 1.1984961 -1.20101535 0.14676766 1.24849164
		 -1.24999988 0.14676768 1.19975531 -1.20101511 0.1467678 -1.24849212 -1.24999964 0.1467678 -1.19975579;
	setAttr -s 8 ".ed[0:7]"  1 3 0 1 0 0 2 4 0 2 3 0 5 7 0 5 4 0 6 0 0
		 6 7 0;
	setAttr -ch 8 ".fc[0]" -type "polyFaces" 
		f 8 -5 5 -3 3 -1 1 -7 7
		mu 0 8 1 6 3 5 0 4 2 7;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ns" 0.04;
	setAttr ".dr" 1;
createNode transform -n "msh_cube_base22" -p "grp_ground";
	setAttr ".t" -type "double3" -2.5 -0.068847642219505872 4.9999999999999982 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base23" -p "grp_ground";
	setAttr ".t" -type "double3" 0 -0.068847642219505872 4.9999999999999982 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base24" -p "grp_ground";
	setAttr ".t" -type "double3" 2.5 -0.068847642219505872 4.9999999999999982 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base25" -p "grp_ground";
	setAttr ".t" -type "double3" 5 -0.068847642219505872 4.9999999999999982 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base27" -p "grp_ground";
	setAttr ".t" -type "double3" -2.5 -0.068847642219505872 2.4999999999999982 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base28" -p "grp_ground";
	setAttr ".t" -type "double3" 0 -0.068847642219505872 2.4999999999999982 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base29" -p "grp_ground";
	setAttr ".t" -type "double3" 2.5 -0.068847642219505872 2.4999999999999982 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base30" -p "grp_ground";
	setAttr ".t" -type "double3" 5 -0.068847642219505872 2.4999999999999982 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base32" -p "grp_ground";
	setAttr ".t" -type "double3" -2.4999999999999996 -0.068847642219505845 -2.2204460492503131e-015 ;
	setAttr ".s" -type "double3" 0.99999999999999989 1 1 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base33" -p "grp_ground";
	setAttr ".t" -type "double3" 0 -0.0688476422195059 -1.7763568394002505e-015 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base34" -p "grp_ground";
	setAttr ".t" -type "double3" 2.4999999999999996 -0.068847642219505845 -2.2204460492503131e-015 ;
	setAttr ".s" -type "double3" 0.99999999999999989 1 1 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base35" -p "grp_ground";
	setAttr ".t" -type "double3" 5 -0.068847642219505872 -1.7763568394002505e-015 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base37" -p "grp_ground";
	setAttr ".t" -type "double3" -2.4999999999999991 -0.068847642219505817 -2.5000000000000027 ;
	setAttr ".s" -type "double3" 0.99999999999999989 1 0.99999999999999989 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.3841857910156245e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".spt" -type "double3" 0 0 5.2939559203393765e-023 ;
createNode transform -n "msh_cube_base38" -p "grp_ground";
	setAttr ".t" -type "double3" 0 -0.068847642219505928 -2.5000000000000018 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base39" -p "grp_ground";
	setAttr ".t" -type "double3" 2.4999999999999991 -0.068847642219505817 -2.5000000000000027 ;
	setAttr ".s" -type "double3" 0.99999999999999989 1 0.99999999999999989 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.3841857910156245e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".spt" -type "double3" 0 0 5.2939559203393765e-023 ;
createNode transform -n "msh_cube_base40" -p "grp_ground";
	setAttr ".t" -type "double3" 5 -0.068847642219505872 -2.5000000000000018 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base42" -p "grp_ground";
	setAttr ".t" -type "double3" -2.4999999999999987 -0.068847642219505761 -5.0000000000000027 ;
	setAttr ".s" -type "double3" 0.99999999999999967 1 0.99999999999999967 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.3841857910156239e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".spt" -type "double3" 0 0 1.0587911840678751e-022 ;
createNode transform -n "msh_cube_base43" -p "grp_ground";
	setAttr ".t" -type "double3" 0 -0.068847642219505928 -5.0000000000000018 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base44" -p "grp_ground";
	setAttr ".t" -type "double3" 2.4999999999999987 -0.068847642219505761 -5.0000000000000027 ;
	setAttr ".s" -type "double3" 0.99999999999999967 1 0.99999999999999967 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.3841857910156239e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".spt" -type "double3" 0 0 1.0587911840678751e-022 ;
createNode transform -n "msh_cube_base45" -p "grp_ground";
	setAttr ".t" -type "double3" 5 -0.068847642219505872 -5.0000000000000018 ;
	setAttr ".rp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 0 0.1942300945520401 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base26" -p "grp_ground";
	setAttr ".t" -type "double3" -5 -0.068847642219505872 2.4999999999999982 ;
	setAttr ".rp" -type "double3" 1.05886602400094 0.072057360490091565 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 1.05886602400094 0.072057360490091565 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base31" -p "grp_ground";
	setAttr ".t" -type "double3" -5 -0.068847642219505872 -1.7763568394002505e-015 ;
	setAttr ".rp" -type "double3" 1.05886602400094 0.072057360490091565 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 1.05886602400094 0.072057360490091565 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base36" -p "grp_ground";
	setAttr ".t" -type "double3" -5 -0.068847642219505872 -2.5000000000000018 ;
	setAttr ".rp" -type "double3" 1.05886602400094 0.072057360490091565 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 1.05886602400094 0.072057360490091565 -2.384185791015625e-007 ;
createNode transform -n "msh_cube_base41" -p "grp_ground";
	setAttr ".t" -type "double3" -5 -0.068847642219505872 -5.0000000000000018 ;
	setAttr ".rp" -type "double3" 1.05886602400094 0.072057360490091565 -2.384185791015625e-007 ;
	setAttr ".sp" -type "double3" 1.05886602400094 0.072057360490091565 -2.384185791015625e-007 ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base22" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base23" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base24" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base25" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base26" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base27" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base28" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base29" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base30" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base31" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base32" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base33" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base34" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base35" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base36" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base37" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base38" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base39" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base40" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base41" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base42" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base43" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base44" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|msh_cube_base21Shape" "msh_cube_base45" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base22" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base23" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base24" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base25" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base26" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base27" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base28" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base29" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base30" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base31" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base32" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base33" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base34" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base35" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base36" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base37" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base38" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base39" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base40" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base41" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base42" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base43" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base44" ;
parent -s -nc -r -add "|grp_ground|msh_cube_base21|polySurfaceShape2" "msh_cube_base45" ;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :renderPartition;
	setAttr -s 9 ".st";
select -ne :initialShadingGroup;
	setAttr -s 49 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 23 ".gn";
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultShaderList1;
	setAttr -s 9 ".s";
select -ne :defaultTextureList1;
	setAttr -s 5 ".tx";
select -ne :lightList1;
	setAttr -s 2 ".l";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
	setAttr -s 5 ".u";
select -ne :defaultRenderingList1;
select -ne :renderGlobalsList1;
select -ne :defaultRenderGlobals;
	setAttr ".ren" -type "string" "mayaHardware2";
	setAttr ".fs" 1;
	setAttr ".ef" 10;
select -ne :defaultLightSet;
	setAttr -s 2 ".dsm";
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 16 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surfaces" "Particles" "Fluids" "Image Planes" "UI:" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Viewport UI"  ;
	setAttr ".otfva" -type "Int32Array" 16 1 1 1 1 1 1
		 1 1 1 1 1 1 1 1 1 1 ;
	setAttr ".aoon" yes;
select -ne :defaultHardwareRenderGlobals;
	setAttr ".fn" -type "string" "im";
	setAttr ".res" -type "string" "ntsc_4d 646 485 1.333";
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "|grp_ground|msh_cube_base41|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base36|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base31|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base26|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base45|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base44|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base43|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base42|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base40|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base39|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base38|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base37|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base35|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base34|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base33|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base32|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base30|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base29|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base28|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base27|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base25|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base23|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base22|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
connectAttr "|grp_ground|msh_cube_base21|msh_cube_base21Shape.iog" ":initialShadingGroup.dsm"
		 -na;
// End of msh_ground.ma
