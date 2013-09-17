S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMG2
Build-Date: 2013.07.04 20:54:23

Crash Information
Process Name: MyHondana
PID: 23344
Date: 2013-07-11 17:40:19(GMT+0900)
Executable File Path: /opt/apps/docomo6003/bin/MyHondana
This process is multi-thread process
pid=23344 tid=23344
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 23344, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x000010a0
r4   = 0xb2e9cfd8, r5   = 0x004a08c8
r6   = 0x00000000, r7   = 0x004d3810
r8   = 0xbecfbf28, r9   = 0x00481178
r10  = 0xb46e3158, fp   = 0xbecfbdb8
ip   = 0xb41b34ac, sp   = 0xbecfbd90
lr   = 0xb3b30277, pc   = 0xb3b4a408
cpsr = 0x88000030

Memory Information
MemTotal:  2063912 KB
MemFree:   1086456 KB
Buffers:     44892 KB
Cached:     498452 KB
VmPeak:     224612 KB
VmSize:     167868 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:      110944 KB
VmRSS:      110944 KB
VmData:      62036 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       66224 KB
VmPTE:         204 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00070000 rw-p [heap]
00070000 02236000 rw-p [heap]
ac667000 ac669000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b0591000 b0595000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b059e000 b0d9d000 rwxp [stack:23346]
b0d9d000 b0eeb000 r-xp /usr/lib/r3p2/libMali.so
b0ef7000 b0f1f000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0f23000 b0f41000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b0f50000 b0f5a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b1294000 b12e0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b12e9000 b12ee000 r-xp /usr/lib/libjson.so.0.0.1
b12f6000 b12fa000 r-xp /usr/lib/liblocation-pos-log.so
b1302000 b1314000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b131c000 b131e000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b1326000 b132b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b1333000 b133e000 r-xp /usr/lib/libdrm-trusted.so.0.0.52
b1346000 b1348000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b1350000 b135d000 r-xp /usr/lib/libdrm-client.so.0.0.90
b1366000 b136e000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b1390000 b13c7000 r-xp /usr/lib/libpulse.so.0.16.2
b13cf000 b1433000 r-xp /usr/lib/libasound.so.2.0.0
b143d000 b1440000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1449000 b144d000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b1456000 b1473000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b147b000 b1480000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1488000 b14b5000 r-xp /usr/lib/libSLP-location.so.0.0.0
b14be000 b14c7000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b14cf000 b14d3000 r-xp /usr/lib/libmmffile.so.0.0.0
b14db000 b14e2000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b14eb000 b1505000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b150d000 b1528000 r-xp /usr/lib/libmedia-service.so.1.0.0
b1530000 b153b000 r-xp /usr/lib/libmdm-common.so.1.0.37
b1543000 b1551000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.7
b155a000 b1561000 r-xp /usr/lib/libenchant.so.1.6.1
b1569000 b156c000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.8
b1575000 b157e000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b1587000 b158b000 r-xp /usr/lib/libmmfsession.so.0.0.0
b1594000 b15a3000 r-xp /usr/lib/libmmfsound.so.0.1.0
b15ab000 b15b0000 r-xp /usr/lib/libmemenv.so.1.1.0
b15b8000 b15f6000 r-xp /usr/lib/libleveldb.so.1.1.0
b15ff000 b1629000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b1632000 b1634000 r-xp /usr/lib/libsecfw.so
b163c000 b1645000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b1650000 b165f000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1667000 b167f000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b1681000 b168e000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b1697000 b16a0000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b16a8000 b16ea000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b16f3000 b178f000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b179b000 b17c0000 r-xp /usr/lib/libxslt.so.1.1.16
b17c9000 b17cb000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b17d3000 b17db000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b17e3000 b17ee000 r-xp /usr/lib/libcapi-location-manager.so.0.1.12
b17f6000 b17f9000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b1801000 b1806000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b180e000 b1835000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.70
b183d000 b1853000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b185c000 b1899000 r-xp /usr/lib/libmdm.so.1.0.63
b18a1000 b18b6000 r-xp /usr/lib/libnetwork.so.0.0.0
b18be000 b18c7000 r-xp /usr/lib/libcapi-web-favorites.so
b18cf000 b2b27000 r-xp /usr/lib/libewebkit2.so.0.10.144.6
b2c1a000 b2c6d000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2c76000 b2c8d000 r-xp /usr/lib/libwifi-direct.so.0.0
b2c95000 b2c9d000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.7
b2ca5000 b2cae000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b2cb6000 b2cc0000 r-xp /usr/lib/libcapi-network-connection.so.0.1.10
b2cc8000 b2d2c000 r-xp /usr/lib/osp/libosp-web.so.1.2.2.0
b2d39000 b2dee000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2dfb000 b2e15000 r-xp /usr/lib/osp/libosp-json.so.1.2.2.0
b2e1e000 b2e3c000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2e48000 b2e4e000 r-xp /usr/lib/libUMP.so
b2e5d000 b2ea8000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana.exe
b2eb2000 b2efa000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2f02000 b2f92000 r-xp /usr/lib/libCOREGL.so.3.0
b2f9c000 b2f9f000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2fa7000 b2fae000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2fb7000 b2fc6000 r-xp /usr/lib/libICE.so.6.3.0
b2fd0000 b2fd5000 r-xp /usr/lib/libSM.so.6.0.1
b2fdd000 b2fde000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2fe6000 b2fe8000 r-xp /usr/lib/libledplayer.so.0.1
b2ff0000 b2ff6000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2ffe000 b2fff000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3008000 b300f000 r-xp /usr/lib/libGLESv2.so.2.0
b3017000 b305e000 r-xp /usr/lib/libtiff.so.5.1.0
b3069000 b3092000 r-xp /usr/lib/libturbojpeg.so
b30ab000 b30af000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b30b8000 b30be000 r-xp /usr/lib/libgif.so.4.1.6
b30c6000 b30e8000 r-xp /usr/lib/libavutil.so.51.73.101
b30f7000 b3125000 r-xp /usr/lib/libswscale.so.2.1.101
b312e000 b3425000 r-xp /usr/lib/libavcodec.so.54.59.100
b374c000 b3765000 r-xp /usr/lib/libpng12.so.0.50.0
b376e000 b3775000 r-xp /usr/lib/libfeedback.so.0.1.4
b377e000 b3791000 r-xp /usr/lib/libtts.so
b379a000 b379c000 r-xp /usr/lib/libEGL.so.1.4
b37a4000 b385b000 r-xp /usr/lib/libcairo.so.2.11200.12
b3865000 b387e000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3888000 b388c000 r-xp /usr/lib/libss-client.so.1.0.0
b3895000 b3897000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana
b389f000 b414b000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b41bc000 b41c5000 r-xp /usr/lib/libslp_devman_plugin.so
b41ce000 b41d0000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b41d8000 b41db000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b41e3000 b41e6000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b41ee000 b41fb000 r-xp /usr/lib/libmodem.so.0.0.0
b4203000 b4206000 r-xp /usr/lib/libdevice-node.so.0.1
b420e000 b421e000 r-xp /usr/lib/libaccounts-svc.so.0.2.68
b4226000 b4229000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b4231000 b4237000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b423f000 b4244000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b424c000 b424d000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b4256000 b4259000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b4261000 b4266000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b426e000 b4271000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b4279000 b427a000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b4282000 b4290000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b4299000 b429f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b42a7000 b42cc000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b42d4000 b42d7000 r-xp /usr/lib/libuuid.so.1.3.0
b42e0000 b42f4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b42fc000 b4304000 r-xp /usr/lib/libminizip.so.1.0.0
b430c000 b4318000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b4321000 b433f000 r-xp /usr/lib/libpcre.so.0.0.1
b4347000 b434b000 r-xp /usr/lib/libheynoti.so.0.0.2
b4353000 b4361000 r-xp /usr/lib/libdeviced.so.0.1.0
b436a000 b4375000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b4382000 b438b000 r-xp /usr/lib/libdevman.so.0.1
b4393000 b4397000 r-xp /usr/lib/libchromium.so.1.0
b439f000 b43b0000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.4
b43b9000 b46c5000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b46ed000 b46f7000 r-xp /lib/libnss_files-2.13.so
b4700000 b4701000 r-xp /usr/lib/libpmapi.so.1.2
b4709000 b4710000 r-xp /usr/lib/libalarm.so.0.0.0
b4718000 b472b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b4734000 b4750000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b4759000 b475c000 r-xp /usr/lib/libiniparser.so.0
b4765000 b47b5000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b47bf000 b47d0000 r-xp /usr/lib/libcom-core.so.0.0.1
b47d8000 b47de000 r-xp /usr/lib/libappsvc.so.0.1.0
b47e6000 b47e8000 r-xp /usr/lib/libdri2.so.0.0.0
b47f0000 b47f8000 r-xp /usr/lib/libdrm.so.2.4.0
b4800000 b4804000 r-xp /usr/lib/libtbm.so.1.0.0
b480c000 b480f000 r-xp /usr/lib/libXv.so.1.0.0
b4817000 b4821000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b482a000 b48f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b490c000 b491b000 r-xp /usr/lib/libnotification.so.0.1.0
b4923000 b4947000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4950000 b4960000 r-xp /lib/libresolv-2.13.so
b4964000 b4966000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b496e000 b4a46000 r-xp /usr/lib/libxml2.so.2.7.8
b4a53000 b4b30000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4b3b000 b4b40000 r-xp /usr/lib/libcheck.so.0.0.0
b4b48000 b4b52000 r-xp /usr/lib/libspdy.so.0.0.0
b4b5b000 b4cae000 r-xp /usr/lib/libcrypto.so.1.0.0
b4ccc000 b4d18000 r-xp /usr/lib/libssl.so.1.0.0
b4d24000 b4d52000 r-xp /usr/lib/libidn.so.11.5.44
b4d5b000 b4d65000 r-xp /usr/lib/libcares.so.2.1.0
b4d6d000 b4d84000 r-xp /lib/libexpat.so.1.5.2
b4d8e000 b4db2000 r-xp /usr/lib/libicule.so.48.1
b4dbb000 b4dc9000 r-xp /usr/lib/libsf_common.so
b4dd2000 b4e6d000 r-xp /usr/lib/libstdc++.so.6.0.14
b4e80000 b4e98000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4e99000 b4e9c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4ea4000 b4ea8000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4eb1000 b4eb6000 r-xp /usr/lib/libffi.so.5.0.10
b4ebe000 b4ebf000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4ec7000 b4ed1000 r-xp /usr/lib/libXext.so.6.4.0
b4eda000 b4edd000 r-xp /usr/lib/libXtst.so.6.1.0
b4ee5000 b4eeb000 r-xp /usr/lib/libXrender.so.1.3.0
b4ef3000 b4ef9000 r-xp /usr/lib/libXrandr.so.2.2.0
b4f01000 b4f02000 r-xp /usr/lib/libXinerama.so.1.0.0
b4f0b000 b4f14000 r-xp /usr/lib/libXi.so.6.1.0
b4f1c000 b4f1f000 r-xp /usr/lib/libXfixes.so.3.1.0
b4f27000 b4f29000 r-xp /usr/lib/libXgesture.so.7.0.0
b4f31000 b4f32000 r-xp /usr/lib/libXdamage.so.1.1.0
b4f3b000 b4f42000 r-xp /usr/lib/libXcursor.so.1.0.2
b4f4a000 b4f6d000 r-xp /usr/lib/libexif.so.12.3.3
b4f81000 b4f8b000 r-xp /usr/lib/libethumb.so.1.7.99
b4f93000 b4fd7000 r-xp /usr/lib/libsndfile.so.1.0.25
b4fe5000 b4fe7000 r-xp /usr/lib/libctxdata.so.0.0.0
b4fef000 b4ffd000 r-xp /usr/lib/libremix.so.0.0.0
b5005000 b5006000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b500e000 b5027000 r-xp /usr/lib/liblua-5.1.so
b5030000 b5037000 r-xp /usr/lib/libembryo.so.1.7.99
b5040000 b5080000 r-xp /usr/lib/libcurl.so.4.3.0
b5089000 b50f3000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5100000 b5124000 r-xp /usr/lib/libfontconfig.so.1.5.0
b512d000 b5189000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b519b000 b51af000 r-xp /usr/lib/libfribidi.so.0.3.1
b51b7000 b520f000 r-xp /usr/lib/libfreetype.so.6.8.1
b521a000 b523e000 r-xp /usr/lib/libjpeg.so.8.0.2
b5256000 b526d000 r-xp /lib/libz.so.1.2.5
b5275000 b527d000 r-xp /usr/lib/libemotion.so.1.7.99
b5285000 b528a000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5293000 b52a1000 r-xp /usr/lib/libsensor.so.1.1.0
b52ad000 b52b3000 r-xp /usr/lib/libappcore-common.so.1.1
b52bb000 b52bd000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.79
b52c5000 b52d0000 r-xp /usr/lib/libresourced.so.0.2.79
b52d8000 b52db000 r-xp /usr/lib/libproc-stat.so.0.2.79
b62d8000 b63c0000 r-xp /usr/lib/libicuuc.so.48.1
b63cd000 b64ed000 r-xp /usr/lib/libicui18n.so.48.1
b64fb000 b64fe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6506000 b650e000 r-xp /usr/lib/libvconf.so.0.2.45
b6516000 b651c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6524000 b6530000 r-xp /usr/lib/libail.so.0.1.0
b6538000 b6543000 r-xp /usr/lib/libaul.so.0.1.0
b654c000 b6563000 r-xp /usr/lib/libecore_input.so.1.7.99
b657e000 b659b000 r-xp /usr/lib/libecore_evas.so.1.7.99
b65a4000 b65a6000 r-xp /usr/lib/libXcomposite.so.1.0.0
b65ae000 b65e2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b65eb000 b661a000 r-xp /usr/lib/libecore_x.so.1.7.99
b6624000 b6663000 r-xp /usr/lib/libeina.so.1.7.99
b666c000 b6681000 r-xp /usr/lib/libecore.so.1.7.99
b6698000 b66b3000 r-xp /usr/lib/libecore_con.so.1.7.99
b66bc000 b66c1000 r-xp /usr/lib/libecore_imf.so.1.7.99
b66c9000 b66d1000 r-xp /usr/lib/libethumb_client.so.1.7.99
b66d9000 b66e2000 r-xp /usr/lib/libedbus.so.1.7.99
b66ea000 b66ec000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b66f4000 b66f8000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6701000 b6717000 r-xp /usr/lib/libefreet.so.1.7.99
b6721000 b677d000 r-xp /usr/lib/libedje.so.1.7.99
b6787000 b6837000 r-xp /usr/lib/libevas.so.1.7.99
b6859000 b686c000 r-xp /usr/lib/libeet.so.1.7.99
b6875000 b68df000 r-xp /lib/libm-2.13.so
b68e8000 b68f0000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.2
b68f1000 b68f8000 r-xp /usr/lib/libutilX.so.1.1.0
b6900000 b6a22000 r-xp /usr/lib/libelementary.so.1.7.99
b6a37000 b6a3a000 r-xp /lib/libattr.so.1.1.0
b6a42000 b6a44000 r-xp /usr/lib/libXau.so.6.0.0
b6a4c000 b6a52000 r-xp /lib/librt-2.13.so
b6a5b000 b6a63000 r-xp /lib/libcrypt-2.13.so
b6a93000 b6a96000 r-xp /lib/libcap.so.2.21
b6a9e000 b6aa0000 r-xp /usr/lib/libiri.so
b6aa8000 b6abd000 r-xp /usr/lib/libxcb.so.1.1.0
b6ac5000 b6ad0000 r-xp /lib/libunwind.so.8.0.1
b6afe000 b6c1b000 r-xp /lib/libc-2.13.so
b6c29000 b6c32000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c3a000 b6c66000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c6f000 b6c72000 r-xp /usr/lib/libbundle.so.0.1.22
b6c7a000 b6c7c000 r-xp /lib/libdl-2.13.so
b6c85000 b6c88000 r-xp /usr/lib/libsmack.so.1.0.0
b6c90000 b6d6a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d73000 b6d87000 r-xp /lib/libpthread-2.13.so
b6d93000 b6d98000 r-xp /usr/lib/libecore_file.so.1.7.99
b6da0000 b6da8000 r-xp /usr/lib/libappcore-efl.so.1.1
b6daa000 b6dab000 r-xp /usr/lib/libdlog.so.0.0.0
b6db4000 b6e21000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e2b000 b6e34000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e3c000 b6f22000 r-xp /usr/lib/libX11.so.6.3.0
b6f2d000 b6f2e000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f36000 b6f3a000 r-xp /usr/lib/libsys-assert.so
b6f42000 b6f5f000 r-xp /lib/ld-2.13.so
becdd000 becfe000 rwxp [stack]
b6f42000 b6f5f000 r-xp /lib/ld-2.13.so
becdd000 becfe000 rwxp [stack]
End of Maps Information

Callstack Information (PID:23344)
Call Stack Count: 34
 0: Tizen::Ui::_ControlImpl::GetFullScreenSizeInfo() + 0x53 (0xb3b4a408) [/usr/lib/osp/libosp-uifw.so] + 0x2ab408
 1: Tizen::Ui::Control::SetShowState(bool) + 0xa (0xb3b30277) [/usr/lib/osp/libosp-uifw.so] + 0x291277
 2: MyHondanaMainForm::SortMenuHide() + 0x2c (0xb2e946ac) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x376ac
 3: SortPopupPanel::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x1c4 (0xb2e9cf84) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x3ff84
 4: non-virtual thunk to SortPopupPanel::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x3c (0xb2e9d014) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x40014
 5: (0xb3bfdf2b) [/usr/lib/osp/libosp-uifw.so] + 0x35ef2b
 6: Tizen::Base::Runtime::_Event::ProcessListeners(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x2bc (0xb450aec1) [/usr/lib/osp/libosp-appfw.so] + 0x151ec1
 7: Tizen::Base::Runtime::_Event::Fire(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x36 (0xb450b0fb) [/usr/lib/osp/libosp-appfw.so] + 0x1520fb
 8: Tizen::Base::Runtime::_Event::Fire(Tizen::Base::Runtime::IEventArg&) + 0x84 (0xb450b1ed) [/usr/lib/osp/libosp-appfw.so] + 0x1521ed
 9: (0xb3cf8733) [/usr/lib/osp/libosp-uifw.so] + 0x459733
10: (0xb3bfb7c7) [/usr/lib/osp/libosp-uifw.so] + 0x35c7c7
11: Tizen::Base::Runtime::_Event::ProcessListeners(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x2bc (0xb450aec1) [/usr/lib/osp/libosp-appfw.so] + 0x151ec1
12: Tizen::Base::Runtime::_Event::Fire(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x36 (0xb450b0fb) [/usr/lib/osp/libosp-appfw.so] + 0x1520fb
13: Tizen::Base::Runtime::_Event::Fire(Tizen::Base::Runtime::IEventArg&) + 0x84 (0xb450b1ed) [/usr/lib/osp/libosp-appfw.so] + 0x1521ed
14: Tizen::Ui::Controls::_CheckButton::FireActionEvent() + 0x7c (0xb3c12b8d) [/usr/lib/osp/libosp-uifw.so] + 0x373b8d
15: (0xb3c18d45) [/usr/lib/osp/libosp-uifw.so] + 0x379d45
16: Tizen::Ui::Controls::_CheckButton::OnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0xe (0xb3c1051f) [/usr/lib/osp/libosp-uifw.so] + 0x37151f
17: Tizen::Ui::_ControlImpl::CallOnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0x21a (0xb3b4ca63) [/usr/lib/osp/libosp-uifw.so] + 0x2ada63
18: Tizen::Ui::_ControlImpl::_PropagatedTouchEventListener::OnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0x20c (0xb3b5489d) [/usr/lib/osp/libosp-uifw.so] + 0x2b589d
19: Tizen::Ui::_UiTouchEvent::FireListener(Tizen::Ui::_ITouchEventListener const*, Tizen::Ui::_Control const*, bool, bool&) + 0x1aa (0xb3bac403) [/usr/lib/osp/libosp-uifw.so] + 0x30d403
20: Tizen::Ui::_UiTouchEvent::OnEventProcessing(Tizen::Ui::_Control const&, bool&) + 0x62 (0xb3bac80f) [/usr/lib/osp/libosp-uifw.so] + 0x30d80f
21: Tizen::Ui::_UiEvent::ProcessEvent(Tizen::Ui::_Control const&, bool&) + 0x32 (0xb3ba0ee3) [/usr/lib/osp/libosp-uifw.so] + 0x301ee3
22: Tizen::Ui::_UiEventManager::ProcessBubblingEvent(Tizen::Base::Collection::LinkedListT<Tizen::Base::_HandleT<Tizen::Ui::_Control> > const&, Tizen::Ui::_UiEvent const&, bool&) + 0x6c (0xb3ba17b1) [/usr/lib/osp/libosp-uifw.so] + 0x3027b1
23: Tizen::Ui::_UiEventManager::ProcessEvent(Tizen::Ui::_UiEvent const&, bool&) + 0x1ec (0xb3ba1a09) [/usr/lib/osp/libosp-uifw.so] + 0x302a09
24: Tizen::Ui::_UiEventManager::Fire(Tizen::Ui::_UiEvent const&) + 0x8a (0xb3ba1aeb) [/usr/lib/osp/libosp-uifw.so] + 0x302aeb
25: Tizen::Ui::_UiEventManager::SendEvent(Tizen::Ui::_UiEvent const&) + 0x6 (0xb3ba1b7b) [/usr/lib/osp/libosp-uifw.so] + 0x302b7b
26: (0xb3b91c7f) [/usr/lib/osp/libosp-uifw.so] + 0x2f2c7f
27: (0xb3b9530f) [/usr/lib/osp/libosp-uifw.so] + 0x2f630f
28: (0xb6673aad) [/usr/lib/libecore.so.1] + 0x7aad
29: (0xb6677153) [/usr/lib/libecore.so.1] + 0xb153
30: ecore_main_loop_begin + 0x30 (0xb6677575) [/usr/lib/libecore.so.1] + 0xb575
31: elm_run + 0x6 (0xb69a9c73) [/usr/lib/libelementary.so.1] + 0xa9c73
32: appcore_efl_main + 0x114 (0xb6da6268) [/usr/lib/libappcore-efl.so.1] + 0x6268
33: app_efl_main + 0xc6 (0xb428bed3) [/usr/lib/libcapi-appfw-application.so.0] + 0x9ed3
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
