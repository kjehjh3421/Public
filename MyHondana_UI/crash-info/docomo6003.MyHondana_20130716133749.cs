S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMG2
Build-Date: 2013.07.04 20:54:23

Crash Information
Process Name: MyHondana
PID: 2522
Date: 2013-07-16 13:37:49(GMT+0900)
Executable File Path: /opt/apps/docomo6003/bin/MyHondana
This process is multi-thread process
pid=2522 tid=2522
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2522, uid 5000)

Register Information
r0   = 0x0222dda0, r1   = 0x00000001
r2   = 0xbea2f150, r3   = 0x00000000
r4   = 0xa8c3d7b8, r5   = 0x00000002
r6   = 0xa8c3d7b8, r7   = 0xb4705094
r8   = 0xbea2f150, r9   = 0x00000000
r10  = 0x00000000, fp   = 0xb6526771
ip   = 0xb46fdfc4, sp   = 0xbea2f150
lr   = 0xb45e9c53, pc   = 0xb45e9cf0
cpsr = 0x68070030

Memory Information
MemTotal:  2063912 KB
MemFree:    599360 KB
Buffers:     71496 KB
Cached:     749876 KB
VmPeak:     278460 KB
VmSize:     201132 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:      149160 KB
VmRSS:      149160 KB
VmData:      92404 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       66284 KB
VmPTE:         254 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00099000 rw-p [heap]
00099000 029df000 rw-p [heap]
adf7d000 adf7f000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
af994000 b0193000 rwxp [stack:2546]
b059a000 b059e000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b05a7000 b0da6000 rwxp [stack:2534]
b0da6000 b0ef4000 r-xp /usr/lib/r3p2/libMali.so
b0f00000 b0f28000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0f2c000 b0f4a000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b0f59000 b0f63000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b129d000 b12e9000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b12f2000 b12f7000 r-xp /usr/lib/libjson.so.0.0.1
b12ff000 b1303000 r-xp /usr/lib/liblocation-pos-log.so
b130b000 b131d000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b1325000 b1327000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b132f000 b1334000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b133c000 b1347000 r-xp /usr/lib/libdrm-trusted.so.0.0.52
b134f000 b1351000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b1359000 b1366000 r-xp /usr/lib/libdrm-client.so.0.0.90
b136f000 b1377000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b1399000 b13d0000 r-xp /usr/lib/libpulse.so.0.16.2
b13d8000 b143c000 r-xp /usr/lib/libasound.so.2.0.0
b1446000 b1449000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1452000 b1456000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b145f000 b147c000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b1484000 b1489000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1491000 b14be000 r-xp /usr/lib/libSLP-location.so.0.0.0
b14c7000 b14d0000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b14d8000 b14dc000 r-xp /usr/lib/libmmffile.so.0.0.0
b14e4000 b14eb000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b14f4000 b150e000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b1516000 b1531000 r-xp /usr/lib/libmedia-service.so.1.0.0
b1539000 b1544000 r-xp /usr/lib/libmdm-common.so.1.0.37
b154c000 b155a000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.7
b1563000 b156a000 r-xp /usr/lib/libenchant.so.1.6.1
b1572000 b1575000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.8
b157e000 b1587000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b1590000 b1594000 r-xp /usr/lib/libmmfsession.so.0.0.0
b159d000 b15ac000 r-xp /usr/lib/libmmfsound.so.0.1.0
b15b4000 b15b9000 r-xp /usr/lib/libmemenv.so.1.1.0
b15c1000 b15ff000 r-xp /usr/lib/libleveldb.so.1.1.0
b1608000 b1632000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b163b000 b163d000 r-xp /usr/lib/libsecfw.so
b1645000 b164e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b1659000 b1668000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1670000 b1688000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b168a000 b1697000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b16a0000 b16a9000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b16b1000 b16f3000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b16fc000 b1798000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b17a4000 b17c9000 r-xp /usr/lib/libxslt.so.1.1.16
b17d2000 b17d4000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b17dc000 b17e4000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b17ec000 b17f7000 r-xp /usr/lib/libcapi-location-manager.so.0.1.12
b17ff000 b1802000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b180a000 b180f000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b1817000 b183e000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.70
b1846000 b185c000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b1865000 b18a2000 r-xp /usr/lib/libmdm.so.1.0.63
b18aa000 b18bf000 r-xp /usr/lib/libnetwork.so.0.0.0
b18c7000 b18d0000 r-xp /usr/lib/libcapi-web-favorites.so
b18d8000 b2b30000 r-xp /usr/lib/libewebkit2.so.0.10.144.6
b2c23000 b2c76000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2c7f000 b2c96000 r-xp /usr/lib/libwifi-direct.so.0.0
b2c9e000 b2ca6000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.7
b2cae000 b2cb7000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b2cbf000 b2cc9000 r-xp /usr/lib/libcapi-network-connection.so.0.1.10
b2cd1000 b2d35000 r-xp /usr/lib/osp/libosp-web.so.1.2.2.0
b2d42000 b2df7000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2e04000 b2e1e000 r-xp /usr/lib/osp/libosp-json.so.1.2.2.0
b2e27000 b2e45000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2e51000 b2e57000 r-xp /usr/lib/libUMP.so
b2e66000 b2ec0000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana.exe
b2ecb000 b2f13000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2f1b000 b2fab000 r-xp /usr/lib/libCOREGL.so.3.0
b2fb5000 b2fb8000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2fc0000 b2fc7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2fd0000 b2fdf000 r-xp /usr/lib/libICE.so.6.3.0
b2fe9000 b2fee000 r-xp /usr/lib/libSM.so.6.0.1
b2ff6000 b2ff7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2fff000 b3001000 r-xp /usr/lib/libledplayer.so.0.1
b3009000 b300f000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3017000 b3018000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3021000 b3028000 r-xp /usr/lib/libGLESv2.so.2.0
b3030000 b3077000 r-xp /usr/lib/libtiff.so.5.1.0
b3082000 b30ab000 r-xp /usr/lib/libturbojpeg.so
b30c4000 b30c8000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b30d1000 b30d7000 r-xp /usr/lib/libgif.so.4.1.6
b30df000 b3101000 r-xp /usr/lib/libavutil.so.51.73.101
b3110000 b313e000 r-xp /usr/lib/libswscale.so.2.1.101
b3147000 b343e000 r-xp /usr/lib/libavcodec.so.54.59.100
b3765000 b377e000 r-xp /usr/lib/libpng12.so.0.50.0
b3787000 b378e000 r-xp /usr/lib/libfeedback.so.0.1.4
b3797000 b37aa000 r-xp /usr/lib/libtts.so
b37b3000 b37b5000 r-xp /usr/lib/libEGL.so.1.4
b37bd000 b3874000 r-xp /usr/lib/libcairo.so.2.11200.12
b387e000 b3897000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b38a1000 b38a5000 r-xp /usr/lib/libss-client.so.1.0.0
b38ae000 b38b0000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana
b38b8000 b4164000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b41d5000 b41de000 r-xp /usr/lib/libslp_devman_plugin.so
b41e7000 b41e9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b41f1000 b41f4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b41fc000 b41ff000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4207000 b4214000 r-xp /usr/lib/libmodem.so.0.0.0
b421c000 b421f000 r-xp /usr/lib/libdevice-node.so.0.1
b4227000 b4237000 r-xp /usr/lib/libaccounts-svc.so.0.2.68
b423f000 b4242000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b424a000 b4250000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4258000 b425d000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b4265000 b4266000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b426f000 b4272000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b427a000 b427f000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b4287000 b428a000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b4292000 b4293000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b429b000 b42a9000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b42b2000 b42b8000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b42c0000 b42e5000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b42ed000 b42f0000 r-xp /usr/lib/libuuid.so.1.3.0
b42f9000 b430d000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4315000 b431d000 r-xp /usr/lib/libminizip.so.1.0.0
b4325000 b4331000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b433a000 b4358000 r-xp /usr/lib/libpcre.so.0.0.1
b4360000 b4364000 r-xp /usr/lib/libheynoti.so.0.0.2
b436c000 b437a000 r-xp /usr/lib/libdeviced.so.0.1.0
b4383000 b438e000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b439b000 b43a4000 r-xp /usr/lib/libdevman.so.0.1
b43ac000 b43b0000 r-xp /usr/lib/libchromium.so.1.0
b43b8000 b43c9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.4
b43d2000 b46de000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b4706000 b4710000 r-xp /lib/libnss_files-2.13.so
b4719000 b471a000 r-xp /usr/lib/libpmapi.so.1.2
b4722000 b4729000 r-xp /usr/lib/libalarm.so.0.0.0
b4731000 b4744000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b474d000 b4769000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b4772000 b4775000 r-xp /usr/lib/libiniparser.so.0
b477e000 b47ce000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b47d8000 b47e9000 r-xp /usr/lib/libcom-core.so.0.0.1
b47f1000 b47f7000 r-xp /usr/lib/libappsvc.so.0.1.0
b47ff000 b4801000 r-xp /usr/lib/libdri2.so.0.0.0
b4809000 b4811000 r-xp /usr/lib/libdrm.so.2.4.0
b4819000 b481d000 r-xp /usr/lib/libtbm.so.1.0.0
b4825000 b4828000 r-xp /usr/lib/libXv.so.1.0.0
b4830000 b483a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4843000 b490f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4925000 b4934000 r-xp /usr/lib/libnotification.so.0.1.0
b493c000 b4960000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4969000 b4979000 r-xp /lib/libresolv-2.13.so
b497d000 b497f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4987000 b4a5f000 r-xp /usr/lib/libxml2.so.2.7.8
b4a6c000 b4b49000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4b54000 b4b59000 r-xp /usr/lib/libcheck.so.0.0.0
b4b61000 b4b6b000 r-xp /usr/lib/libspdy.so.0.0.0
b4b74000 b4cc7000 r-xp /usr/lib/libcrypto.so.1.0.0
b4ce5000 b4d31000 r-xp /usr/lib/libssl.so.1.0.0
b4d3d000 b4d6b000 r-xp /usr/lib/libidn.so.11.5.44
b4d74000 b4d7e000 r-xp /usr/lib/libcares.so.2.1.0
b4d86000 b4d9d000 r-xp /lib/libexpat.so.1.5.2
b4da7000 b4dcb000 r-xp /usr/lib/libicule.so.48.1
b4dd4000 b4de2000 r-xp /usr/lib/libsf_common.so
b4deb000 b4e86000 r-xp /usr/lib/libstdc++.so.6.0.14
b4e99000 b4eb1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4eb2000 b4eb5000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4ebd000 b4ec1000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4eca000 b4ecf000 r-xp /usr/lib/libffi.so.5.0.10
b4ed7000 b4ed8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4ee0000 b4eea000 r-xp /usr/lib/libXext.so.6.4.0
b4ef3000 b4ef6000 r-xp /usr/lib/libXtst.so.6.1.0
b4efe000 b4f04000 r-xp /usr/lib/libXrender.so.1.3.0
b4f0c000 b4f12000 r-xp /usr/lib/libXrandr.so.2.2.0
b4f1a000 b4f1b000 r-xp /usr/lib/libXinerama.so.1.0.0
b4f24000 b4f2d000 r-xp /usr/lib/libXi.so.6.1.0
b4f35000 b4f38000 r-xp /usr/lib/libXfixes.so.3.1.0
b4f40000 b4f42000 r-xp /usr/lib/libXgesture.so.7.0.0
b4f4a000 b4f4b000 r-xp /usr/lib/libXdamage.so.1.1.0
b4f54000 b4f5b000 r-xp /usr/lib/libXcursor.so.1.0.2
b4f63000 b4f86000 r-xp /usr/lib/libexif.so.12.3.3
b4f9a000 b4fa4000 r-xp /usr/lib/libethumb.so.1.7.99
b4fac000 b4ff0000 r-xp /usr/lib/libsndfile.so.1.0.25
b4ffe000 b5000000 r-xp /usr/lib/libctxdata.so.0.0.0
b5008000 b5016000 r-xp /usr/lib/libremix.so.0.0.0
b501e000 b501f000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5027000 b5040000 r-xp /usr/lib/liblua-5.1.so
b5049000 b5050000 r-xp /usr/lib/libembryo.so.1.7.99
b5059000 b5099000 r-xp /usr/lib/libcurl.so.4.3.0
b50a2000 b510c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5119000 b513d000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5146000 b51a2000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b51b4000 b51c8000 r-xp /usr/lib/libfribidi.so.0.3.1
b51d0000 b5228000 r-xp /usr/lib/libfreetype.so.6.8.1
b5233000 b5257000 r-xp /usr/lib/libjpeg.so.8.0.2
b526f000 b5286000 r-xp /lib/libz.so.1.2.5
b528e000 b5296000 r-xp /usr/lib/libemotion.so.1.7.99
b529e000 b52a3000 r-xp /usr/lib/libecore_fb.so.1.7.99
b52ac000 b52ba000 r-xp /usr/lib/libsensor.so.1.1.0
b52c6000 b52cc000 r-xp /usr/lib/libappcore-common.so.1.1
b52d4000 b52d6000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.79
b52de000 b52e9000 r-xp /usr/lib/libresourced.so.0.2.79
b52f1000 b52f4000 r-xp /usr/lib/libproc-stat.so.0.2.79
b62f1000 b63d9000 r-xp /usr/lib/libicuuc.so.48.1
b63e6000 b6506000 r-xp /usr/lib/libicui18n.so.48.1
b6514000 b6517000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b651f000 b6527000 r-xp /usr/lib/libvconf.so.0.2.45
b652f000 b6535000 r-xp /usr/lib/libxdgmime.so.1.1.0
b653d000 b6549000 r-xp /usr/lib/libail.so.0.1.0
b6551000 b655c000 r-xp /usr/lib/libaul.so.0.1.0
b6565000 b657c000 r-xp /usr/lib/libecore_input.so.1.7.99
b6597000 b65b4000 r-xp /usr/lib/libecore_evas.so.1.7.99
b65bd000 b65bf000 r-xp /usr/lib/libXcomposite.so.1.0.0
b65c7000 b65fb000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6604000 b6633000 r-xp /usr/lib/libecore_x.so.1.7.99
b663d000 b667c000 r-xp /usr/lib/libeina.so.1.7.99
b6685000 b669a000 r-xp /usr/lib/libecore.so.1.7.99
b66b1000 b66cc000 r-xp /usr/lib/libecore_con.so.1.7.99
b66d5000 b66da000 r-xp /usr/lib/libecore_imf.so.1.7.99
b66e2000 b66ea000 r-xp /usr/lib/libethumb_client.so.1.7.99
b66f2000 b66fb000 r-xp /usr/lib/libedbus.so.1.7.99
b6703000 b6705000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b670d000 b6711000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b671a000 b6730000 r-xp /usr/lib/libefreet.so.1.7.99
b673a000 b6796000 r-xp /usr/lib/libedje.so.1.7.99
b67a0000 b6850000 r-xp /usr/lib/libevas.so.1.7.99
b6872000 b6885000 r-xp /usr/lib/libeet.so.1.7.99
b688e000 b68f8000 r-xp /lib/libm-2.13.so
b6901000 b6909000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.2
b690a000 b6911000 r-xp /usr/lib/libutilX.so.1.1.0
b6919000 b6a3b000 r-xp /usr/lib/libelementary.so.1.7.99
b6a50000 b6a53000 r-xp /lib/libattr.so.1.1.0
b6a5b000 b6a5d000 r-xp /usr/lib/libXau.so.6.0.0
b6a65000 b6a6b000 r-xp /lib/librt-2.13.so
b6a74000 b6a7c000 r-xp /lib/libcrypt-2.13.so
b6aac000 b6aaf000 r-xp /lib/libcap.so.2.21
b6ab7000 b6ab9000 r-xp /usr/lib/libiri.so
b6ac1000 b6ad6000 r-xp /usr/lib/libxcb.so.1.1.0
b6ade000 b6ae9000 r-xp /lib/libunwind.so.8.0.1
b6b17000 b6c34000 r-xp /lib/libc-2.13.so
b6c42000 b6c4b000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c53000 b6c7f000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c88000 b6c8b000 r-xp /usr/lib/libbundle.so.0.1.22
b6c93000 b6c95000 r-xp /lib/libdl-2.13.so
b6c9e000 b6ca1000 r-xp /usr/lib/libsmack.so.1.0.0
b6ca9000 b6d83000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d8c000 b6da0000 r-xp /lib/libpthread-2.13.so
b6dac000 b6db1000 r-xp /usr/lib/libecore_file.so.1.7.99
b6db9000 b6dc1000 r-xp /usr/lib/libappcore-efl.so.1.1
b6dc3000 b6dc4000 r-xp /usr/lib/libdlog.so.0.0.0
b6dcd000 b6e3a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e44000 b6e4d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e55000 b6f3b000 r-xp /usr/lib/libX11.so.6.3.0
b6f46000 b6f47000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f4f000 b6f53000 r-xp /usr/lib/libsys-assert.so
b6f5b000 b6f78000 r-xp /lib/ld-2.13.so
bea10000 bea31000 rwxp [stack]
b6f4f000 b6f53000 r-xp /usr/lib/libsys-assert.so
b6f5b000 b6f78000 r-xp /lib/ld-2.13.so
bea10000 bea31000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2522)
Call Stack Count: 12
 0: (0xb45e9cf0) [/usr/lib/osp/libosp-appfw.so] + 0x217cf0
 1: (0xb4265b4b) [/usr/lib/libcapi-system-power.so.0] + 0xb4b
 2: (0xb652565d) [/usr/lib/libvconf.so.0] + 0x665d
 3: (0xb6d0d783) [/usr/lib/libglib-2.0.so.0] + 0x64783
 4: g_main_context_dispatch + 0xce (0xb6ce1a37) [/usr/lib/libglib-2.0.so.0] + 0x38a37
 5: (0xb66942df) [/usr/lib/libecore.so.1] + 0xf2df
 6: (0xb668f861) [/usr/lib/libecore.so.1] + 0xa861
 7: (0xb6690253) [/usr/lib/libecore.so.1] + 0xb253
 8: ecore_main_loop_begin + 0x30 (0xb6690575) [/usr/lib/libecore.so.1] + 0xb575
 9: elm_run + 0x6 (0xb69c2c73) [/usr/lib/libelementary.so.1] + 0xa9c73
10: appcore_efl_main + 0x114 (0xb6dbf268) [/usr/lib/libappcore-efl.so.1] + 0x6268
11: app_efl_main + 0xc6 (0xb42a4ed3) [/usr/lib/libcapi-appfw-application.so.0] + 0x9ed3
End of Call Stack

Package Information
Package Name: docomo6003.MyHondana
Package ID : docomo6003
Version: 1.0.0
Package Type: tpk
App Name: d book MyShelf
App ID: docomo6003.MyHondana
Type: Application
Categories: (NULL)
