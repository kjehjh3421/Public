S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMG2
Build-Date: 2013.07.04 20:54:23

Crash Information
Process Name: MyHondana
PID: 16690
Date: 2013-07-19 17:04:19(GMT+0900)
Executable File Path: /opt/apps/docomo6003/bin/MyHondana
This process is multi-thread process
pid=16690 tid=16690
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 16690, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00434108, r3   = 0xb3d0f4b1
r4   = 0x00428858, r5   = 0x00434100
r6   = 0x00000000, r7   = 0x00428858
r8   = 0xbea2ef50, r9   = 0x00313e30
r10  = 0xb46fc158, fp   = 0xbea2ee38
ip   = 0xb41ceba0, sp   = 0xbea2eb70
lr   = 0xb3ea8707, pc   = 0xb3eab67c
cpsr = 0x68000030

Memory Information
MemTotal:  2063912 KB
MemFree:    659440 KB
Buffers:     96800 KB
Cached:     640488 KB
VmPeak:     288792 KB
VmSize:     212652 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:      128276 KB
VmRSS:      110316 KB
VmData:     102740 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       67492 KB
VmPTE:         206 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 0007d000 rw-p [heap]
0007d000 01e0d000 rw-p [heap]
a8043000 a8842000 rwxp [stack:16733]
a9ce6000 aa4e5000 rwxp [stack:16730]
aa4e6000 aace5000 rwxp [stack:16729]
ab001000 ab800000 rwxp [stack:16727]
ab96a000 ab9e8000 r-xp /usr/lib/libgnutls.so.26.22.4
ab9f5000 ac1f4000 rwxp [stack:16726]
ad958000 ad998000 r-xp /usr/lib/libgmp.so.10.0.1
ae05f000 ae083000 r-xp /usr/lib/libnettle.so.4.0
af984000 b0183000 rwxp [stack:16704]
b0186000 b0193000 r-xp /usr/lib/libhogweed.so.2.0
b0320000 b032c000 r-xp /usr/lib/gio/modules/libgiognutls.so
b0334000 b0335000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b033d000 b033f000 r-xp /usr/lib/remix/libtizen_sound_player.so.1.0.0
b0347000 b0349000 r-xp /usr/lib/remix/libeet_sndfile_reader.so
b0352000 b0353000 r-xp /usr/lib/edje/modules/multisense_factory/linux-gnueabi-armv7l-1.0.0/module.so
b03e6000 b03fd000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b040a000 b0413000 r-xp /usr/lib/libefl-assist.so.0.1.0
b058a000 b058e000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b0597000 b0d96000 rwxp [stack:16692]
b0d96000 b0ee4000 r-xp /usr/lib/r3p2/libMali.so
b0ef0000 b0f18000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0f1c000 b0f3a000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b0f49000 b0f53000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b128d000 b12d9000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b12e2000 b12e7000 r-xp /usr/lib/libjson.so.0.0.1
b12ef000 b12f3000 r-xp /usr/lib/liblocation-pos-log.so
b12fb000 b130d000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b1315000 b1317000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b131f000 b1324000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b132c000 b1337000 r-xp /usr/lib/libdrm-trusted.so.0.0.52
b133f000 b1341000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b1349000 b1356000 r-xp /usr/lib/libdrm-client.so.0.0.90
b135f000 b1367000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b1389000 b13c0000 r-xp /usr/lib/libpulse.so.0.16.2
b13c8000 b142c000 r-xp /usr/lib/libasound.so.2.0.0
b1436000 b1439000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1442000 b1446000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b144f000 b146c000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b1474000 b1479000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1481000 b14ae000 r-xp /usr/lib/libSLP-location.so.0.0.0
b14b7000 b14c0000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b14c8000 b14cc000 r-xp /usr/lib/libmmffile.so.0.0.0
b14d4000 b14db000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b14e4000 b14fe000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b1506000 b1521000 r-xp /usr/lib/libmedia-service.so.1.0.0
b1529000 b1534000 r-xp /usr/lib/libmdm-common.so.1.0.37
b153c000 b154a000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.7
b1553000 b155a000 r-xp /usr/lib/libenchant.so.1.6.1
b1562000 b1565000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.8
b156e000 b1577000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b1580000 b1584000 r-xp /usr/lib/libmmfsession.so.0.0.0
b158d000 b159c000 r-xp /usr/lib/libmmfsound.so.0.1.0
b15a4000 b15a9000 r-xp /usr/lib/libmemenv.so.1.1.0
b15b1000 b15ef000 r-xp /usr/lib/libleveldb.so.1.1.0
b15f8000 b1622000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b162b000 b162d000 r-xp /usr/lib/libsecfw.so
b1635000 b163e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b1649000 b1658000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1660000 b1678000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b167a000 b1687000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b1690000 b1699000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b16a1000 b16e3000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b16ec000 b1788000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b1794000 b17b9000 r-xp /usr/lib/libxslt.so.1.1.16
b17c2000 b17c4000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b17cc000 b17d4000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b17dc000 b17e7000 r-xp /usr/lib/libcapi-location-manager.so.0.1.12
b17ef000 b17f2000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b17fa000 b17ff000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b1807000 b182e000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.70
b1836000 b184c000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b1855000 b1892000 r-xp /usr/lib/libmdm.so.1.0.63
b189a000 b18af000 r-xp /usr/lib/libnetwork.so.0.0.0
b18b7000 b18c0000 r-xp /usr/lib/libcapi-web-favorites.so
b18c8000 b2b20000 r-xp /usr/lib/libewebkit2.so.0.10.144.6
b2c13000 b2c66000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2c6f000 b2c86000 r-xp /usr/lib/libwifi-direct.so.0.0
b2c8e000 b2c96000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.7
b2c9e000 b2ca7000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b2caf000 b2cb9000 r-xp /usr/lib/libcapi-network-connection.so.0.1.10
b2cc1000 b2d25000 r-xp /usr/lib/osp/libosp-web.so.1.2.2.0
b2d32000 b2de7000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2df4000 b2e0e000 r-xp /usr/lib/osp/libosp-json.so.1.2.2.0
b2e17000 b2e35000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2e41000 b2e47000 r-xp /usr/lib/libUMP.so
b2e56000 b2ebf000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana.exe
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

Callstack Information (PID:16690)
Call Stack Count: 37
 0: (0xb3eab67c) [/usr/lib/osp/libosp-uifw.so] + 0x5f367c
 1: Tizen::Graphics::_BitmapImpl::__CheckValidity(bool) + 0x12 (0xb3ea8707) [/usr/lib/osp/libosp-uifw.so] + 0x5f0707
 2: Tizen::Graphics::_BitmapImpl::CloneN(Tizen::Graphics::Bitmap const&) + 0x22 (0xb3ea87af) [/usr/lib/osp/libosp-uifw.so] + 0x5f07af
 3: Tizen::Ui::Controls::_Button::SetBackgroundBitmap(Tizen::Ui::Controls::_ButtonStatus, Tizen::Graphics::Bitmap const&) + 0xc (0xb3c1dac1) [/usr/lib/osp/libosp-uifw.so] + 0x365ac1
 4: (0xb3d100cd) [/usr/lib/osp/libosp-uifw.so] + 0x4580cd
 5: Tizen::Ui::Controls::Button::SetNormalBackgroundBitmap(Tizen::Graphics::Bitmap const&) + 0x18 (0xb3bf58d9) [/usr/lib/osp/libosp-uifw.so] + 0x33d8d9
 6: MyHondanaMainForm::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x71c (0xb2e93bc8) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x3dbc8
 7: non-virtual thunk to MyHondanaMainForm::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x3c (0xb2e94204) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x3e204
 8: (0xb3c16f2b) [/usr/lib/osp/libosp-uifw.so] + 0x35ef2b
 9: Tizen::Base::Runtime::_Event::ProcessListeners(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x2bc (0xb4523ec1) [/usr/lib/osp/libosp-appfw.so] + 0x151ec1
10: Tizen::Base::Runtime::_Event::Fire(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x36 (0xb45240fb) [/usr/lib/osp/libosp-appfw.so] + 0x1520fb
11: Tizen::Base::Runtime::_Event::Fire(Tizen::Base::Runtime::IEventArg&) + 0x84 (0xb45241ed) [/usr/lib/osp/libosp-appfw.so] + 0x1521ed
12: (0xb3d0f4a7) [/usr/lib/osp/libosp-uifw.so] + 0x4574a7
13: (0xb3c147c7) [/usr/lib/osp/libosp-uifw.so] + 0x35c7c7
14: Tizen::Base::Runtime::_Event::ProcessListeners(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x2bc (0xb4523ec1) [/usr/lib/osp/libosp-appfw.so] + 0x151ec1
15: Tizen::Base::Runtime::_Event::Fire(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x36 (0xb45240fb) [/usr/lib/osp/libosp-appfw.so] + 0x1520fb
16: Tizen::Base::Runtime::_Event::Fire(Tizen::Base::Runtime::IEventArg&) + 0x84 (0xb45241ed) [/usr/lib/osp/libosp-appfw.so] + 0x1521ed
17: Tizen::Ui::Controls::_Button::FireActionEvent() + 0x26 (0xb3c1df7f) [/usr/lib/osp/libosp-uifw.so] + 0x365f7f
18: (0xb3c20b29) [/usr/lib/osp/libosp-uifw.so] + 0x368b29
19: Tizen::Ui::Controls::_Button::OnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0xe (0xb3c1bebb) [/usr/lib/osp/libosp-uifw.so] + 0x363ebb
20: Tizen::Ui::_ControlImpl::CallOnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0x21a (0xb3b65a63) [/usr/lib/osp/libosp-uifw.so] + 0x2ada63
21: Tizen::Ui::_ControlImpl::_PropagatedTouchEventListener::OnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0x20c (0xb3b6d89d) [/usr/lib/osp/libosp-uifw.so] + 0x2b589d
22: Tizen::Ui::_UiTouchEvent::FireListener(Tizen::Ui::_ITouchEventListener const*, Tizen::Ui::_Control const*, bool, bool&) + 0x1aa (0xb3bc5403) [/usr/lib/osp/libosp-uifw.so] + 0x30d403
23: Tizen::Ui::_UiTouchEvent::OnEventProcessing(Tizen::Ui::_Control const&, bool&) + 0x62 (0xb3bc580f) [/usr/lib/osp/libosp-uifw.so] + 0x30d80f
24: Tizen::Ui::_UiEvent::ProcessEvent(Tizen::Ui::_Control const&, bool&) + 0x32 (0xb3bb9ee3) [/usr/lib/osp/libosp-uifw.so] + 0x301ee3
25: Tizen::Ui::_UiEventManager::ProcessBubblingEvent(Tizen::Base::Collection::LinkedListT<Tizen::Base::_HandleT<Tizen::Ui::_Control> > const&, Tizen::Ui::_UiEvent const&, bool&) + 0x6c (0xb3bba7b1) [/usr/lib/osp/libosp-uifw.so] + 0x3027b1
26: Tizen::Ui::_UiEventManager::ProcessEvent(Tizen::Ui::_UiEvent const&, bool&) + 0x1ec (0xb3bbaa09) [/usr/lib/osp/libosp-uifw.so] + 0x302a09
27: Tizen::Ui::_UiEventManager::Fire(Tizen::Ui::_UiEvent const&) + 0x8a (0xb3bbaaeb) [/usr/lib/osp/libosp-uifw.so] + 0x302aeb
28: Tizen::Ui::_UiEventManager::SendEvent(Tizen::Ui::_UiEvent const&) + 0x6 (0xb3bbab7b) [/usr/lib/osp/libosp-uifw.so] + 0x302b7b
29: (0xb3baac7f) [/usr/lib/osp/libosp-uifw.so] + 0x2f2c7f
30: (0xb3bae30f) [/usr/lib/osp/libosp-uifw.so] + 0x2f630f
31: (0xb668caad) [/usr/lib/libecore.so.1] + 0x7aad
32: (0xb6690153) [/usr/lib/libecore.so.1] + 0xb153
33: ecore_main_loop_begin + 0x30 (0xb6690575) [/usr/lib/libecore.so.1] + 0xb575
34: elm_run + 0x6 (0xb69c2c73) [/usr/lib/libelementary.so.1] + 0xa9c73
35: appcore_efl_main + 0x114 (0xb6dbf268) [/usr/lib/libappcore-efl.so.1] + 0x6268
36: app_efl_main + 0xc6 (0xb42a4ed3) [/usr/lib/libcapi-appfw-application.so.0] + 0x9ed3
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
