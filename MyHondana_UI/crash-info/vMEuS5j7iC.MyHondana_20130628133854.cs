S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMF4
Build-Date: 2013.06.25 21:23:12

Crash Information
Process Name: MyHondana
PID: 26673
Date: 2013-06-28 13:38:54(GMT+0900)
Executable File Path: /opt/apps/vMEuS5j7iC/bin/MyHondana
This process is multi-thread process
pid=26673 tid=26673
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 26673, uid 5000)
      TIMER: -2

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000006, r3   = 0x00000000
r4   = 0x001b5f20, r5   = 0x00000430
r6   = 0x00000001, r7   = 0x0024c688
r8   = 0xbefa7f90, r9   = 0x00081df8
r10  = 0xb46db180, fp   = 0xbefa7ea0
ip   = 0xb4197ce4, sp   = 0xbefa7e48
lr   = 0xb3b1bcb1, pc   = 0xb3b379b4
cpsr = 0x680f0030

Memory Information
MemTotal:  2063912 KB
MemFree:   1239512 KB
Buffers:     40188 KB
Cached:     432076 KB
VmPeak:     158904 KB
VmSize:     137616 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       51624 KB
VmRSS:       51624 KB
VmData:      36156 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       65968 KB
VmPTE:         134 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00070000 rw-p [heap]
00070000 01493000 rw-p [heap]
b05be000 b05c2000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b05cb000 b0dca000 rwxp [stack:26675]
b0dca000 b0f18000 r-xp /usr/lib/r3p2/libMali.so
b0f24000 b0f4c000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0f50000 b0f6e000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b0f80000 b0f86000 r-xp /usr/lib/libUMP.so
b12c7000 b1313000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b131c000 b1321000 r-xp /usr/lib/libjson.so.0.0.1
b1329000 b132d000 r-xp /usr/lib/liblocation-pos-log.so
b1335000 b1340000 r-xp /usr/lib/libmdm-common.so.1.0.37
b1348000 b135a000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b1362000 b1364000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b136c000 b1371000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b1379000 b1384000 r-xp /usr/lib/libdrm-trusted.so.0.0.51
b138c000 b138e000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b1396000 b13a3000 r-xp /usr/lib/libdrm-client.so.0.0.90
b13ac000 b13b4000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b13d6000 b140d000 r-xp /usr/lib/libpulse.so.0.16.2
b1415000 b1479000 r-xp /usr/lib/libasound.so.2.0.0
b1483000 b1486000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b148f000 b1493000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b149c000 b14b9000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b14c1000 b14c5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b14cd000 b14fa000 r-xp /usr/lib/libSLP-location.so.0.0.0
b1503000 b1540000 r-xp /usr/lib/libmdm.so.1.0.63
b1548000 b154c000 r-xp /usr/lib/libss-client.so.1.0.0
b1555000 b155e000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b1566000 b156a000 r-xp /usr/lib/libmmffile.so.0.0.0
b1572000 b1579000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b1581000 b159b000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b15a3000 b15be000 r-xp /usr/lib/libmedia-service.so.1.0.0
b15c6000 b15db000 r-xp /usr/lib/libnetwork.so.0.0.0
b15e3000 b15f1000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.6
b15fa000 b1601000 r-xp /usr/lib/libenchant.so.1.6.1
b1609000 b160c000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.8
b1615000 b161e000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b1627000 b162b000 r-xp /usr/lib/libmmfsession.so.0.0.0
b1634000 b1642000 r-xp /usr/lib/libmmfsound.so.0.1.0
b164a000 b164f000 r-xp /usr/lib/libmemenv.so.1.1.0
b1657000 b1695000 r-xp /usr/lib/libleveldb.so.1.1.0
b169e000 b16c8000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b16d1000 b16d3000 r-xp /usr/lib/libsecfw.so
b16db000 b16e4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b16ef000 b16fe000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1706000 b171e000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b1720000 b172d000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b1736000 b173f000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b1747000 b1789000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b1792000 b182e000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b183a000 b185f000 r-xp /usr/lib/libxslt.so.1.1.16
b1868000 b186a000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b1872000 b187a000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b1882000 b188d000 r-xp /usr/lib/libcapi-location-manager.so.0.1.12
b1895000 b18b0000 r-xp /usr/lib/libwifi-direct.so.0.0
b18b8000 b18c0000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.6
b18c8000 b18d1000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b18d9000 b18dc000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b18e4000 b190b000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.70
b1913000 b1929000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b1932000 b193c000 r-xp /usr/lib/libcapi-network-connection.so.0.1.10
b1944000 b194d000 r-xp /usr/lib/libcapi-web-favorites.so
b1955000 b2ba5000 r-xp /usr/lib/libewebkit2.so.0.10.141.3
b2c97000 b2d4c000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2d59000 b2d77000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2d80000 b2d9a000 r-xp /usr/lib/osp/libosp-json.so.1.2.1.0
b2da3000 b2df6000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2dff000 b2e63000 r-xp /usr/lib/osp/libosp-web.so.1.2.1.0
b2e76000 b2e80000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2e88000 b2ea0000 r-xp /opt/usr/apps/vMEuS5j7iC/bin/MyHondana.exe
b2ea2000 b2eea000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2ef2000 b2f82000 r-xp /usr/lib/libCOREGL.so.3.0
b2f8c000 b2f8f000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2f97000 b2f9e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2fa7000 b2fb6000 r-xp /usr/lib/libICE.so.6.3.0
b2fc0000 b2fc5000 r-xp /usr/lib/libSM.so.6.0.1
b2fcd000 b2fce000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2fd6000 b2fd8000 r-xp /usr/lib/libledplayer.so.0.1
b2fe0000 b2fe6000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2fee000 b2fef000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2ff8000 b2fff000 r-xp /usr/lib/libGLESv2.so.2.0
b3007000 b304e000 r-xp /usr/lib/libtiff.so.5.1.0
b3059000 b3082000 r-xp /usr/lib/libturbojpeg.so
b309b000 b309f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b30a8000 b30ae000 r-xp /usr/lib/libgif.so.4.1.6
b30b6000 b30d8000 r-xp /usr/lib/libavutil.so.51.73.101
b30e7000 b3115000 r-xp /usr/lib/libswscale.so.2.1.101
b311e000 b3415000 r-xp /usr/lib/libavcodec.so.54.59.100
b373c000 b3755000 r-xp /usr/lib/libpng12.so.0.50.0
b375e000 b3765000 r-xp /usr/lib/libfeedback.so.0.1.4
b376e000 b3781000 r-xp /usr/lib/libtts.so
b3789000 b378b000 r-xp /usr/lib/libEGL.so.1.4
b3793000 b384a000 r-xp /usr/lib/libcairo.so.2.11200.12
b3854000 b386d000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3877000 b387c000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b3884000 b3886000 r-xp /opt/usr/apps/vMEuS5j7iC/bin/MyHondana
b388e000 b4130000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b41a0000 b41a9000 r-xp /usr/lib/libslp_devman_plugin.so
b41b2000 b41b4000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b41bc000 b41bf000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b41c7000 b41ca000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b41d2000 b41df000 r-xp /usr/lib/libmodem.so.0.0.0
b41e7000 b41ea000 r-xp /usr/lib/libdevice-node.so.0.1
b41f2000 b4202000 r-xp /usr/lib/libaccounts-svc.so.0.2.68
b420a000 b420d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b4215000 b4220000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4228000 b422f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4238000 b423d000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b4245000 b4246000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b424f000 b4252000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b425a000 b425f000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b4267000 b426a000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b4272000 b4273000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b427b000 b4289000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b4292000 b4298000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b42a0000 b42c5000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b42cd000 b42d0000 r-xp /usr/lib/libuuid.so.1.3.0
b42d9000 b42ed000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b42f5000 b42f6000 r-xp /usr/lib/libpmapi.so.1.2
b42fe000 b4306000 r-xp /usr/lib/libminizip.so.1.0.0
b430e000 b431a000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b4323000 b4341000 r-xp /usr/lib/libpcre.so.0.0.1
b4349000 b434d000 r-xp /usr/lib/libheynoti.so.0.0.2
b4355000 b4363000 r-xp /usr/lib/libdeviced.so.0.1.0
b436c000 b4377000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b4384000 b438d000 r-xp /usr/lib/libdevman.so.0.1
b4395000 b4399000 r-xp /usr/lib/libchromium.so.1.0
b43a1000 b43a8000 r-xp /usr/lib/libalarm.so.0.0.0
b43b0000 b46bd000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b46e5000 b46ef000 r-xp /lib/libnss_files-2.13.so
b46ff000 b470f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.3
b4710000 b4723000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b472b000 b4748000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b4750000 b4753000 r-xp /usr/lib/libiniparser.so.0
b475c000 b47ac000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b47b6000 b47ca000 r-xp /usr/lib/libcom-core.so.0.0.1
b47d2000 b47d8000 r-xp /usr/lib/libappsvc.so.0.1.0
b47e0000 b47e2000 r-xp /usr/lib/libdri2.so.0.0.0
b47ea000 b47f2000 r-xp /usr/lib/libdrm.so.2.4.0
b47fa000 b47fe000 r-xp /usr/lib/libtbm.so.1.0.0
b4806000 b4809000 r-xp /usr/lib/libXv.so.1.0.0
b4811000 b48dd000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b48f3000 b4902000 r-xp /usr/lib/libnotification.so.0.1.0
b490a000 b492e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4937000 b4947000 r-xp /lib/libresolv-2.13.so
b494b000 b494d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4955000 b4a2d000 r-xp /usr/lib/libxml2.so.2.7.8
b4a3a000 b4b17000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4b22000 b4b27000 r-xp /usr/lib/libcheck.so.0.0.0
b4b2f000 b4b39000 r-xp /usr/lib/libspdy.so.0.0.0
b4b42000 b4c95000 r-xp /usr/lib/libcrypto.so.1.0.0
b4cb3000 b4cff000 r-xp /usr/lib/libssl.so.1.0.0
b4d0b000 b4d39000 r-xp /usr/lib/libidn.so.11.5.44
b4d42000 b4d4c000 r-xp /usr/lib/libcares.so.2.1.0
b4d54000 b4d6b000 r-xp /lib/libexpat.so.1.5.2
b4d75000 b4d99000 r-xp /usr/lib/libicule.so.48.1
b4da2000 b4db0000 r-xp /usr/lib/libsf_common.so
b4db9000 b4e54000 r-xp /usr/lib/libstdc++.so.6.0.14
b4e67000 b4e7f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4e80000 b4e83000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4e8b000 b4e8f000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4e98000 b4e9d000 r-xp /usr/lib/libffi.so.5.0.10
b4ea5000 b4ea6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4eae000 b4eb8000 r-xp /usr/lib/libXext.so.6.4.0
b4ec1000 b4ec4000 r-xp /usr/lib/libXtst.so.6.1.0
b4ecc000 b4ed2000 r-xp /usr/lib/libXrender.so.1.3.0
b4eda000 b4ee0000 r-xp /usr/lib/libXrandr.so.2.2.0
b4ee8000 b4ee9000 r-xp /usr/lib/libXinerama.so.1.0.0
b4ef2000 b4efb000 r-xp /usr/lib/libXi.so.6.1.0
b4f03000 b4f06000 r-xp /usr/lib/libXfixes.so.3.1.0
b4f0e000 b4f10000 r-xp /usr/lib/libXgesture.so.7.0.0
b4f18000 b4f19000 r-xp /usr/lib/libXdamage.so.1.1.0
b4f22000 b4f29000 r-xp /usr/lib/libXcursor.so.1.0.2
b4f31000 b4f54000 r-xp /usr/lib/libexif.so.12.3.3
b4f68000 b4f72000 r-xp /usr/lib/libethumb.so.1.7.99
b4f7a000 b4fbe000 r-xp /usr/lib/libsndfile.so.1.0.25
b4fcc000 b4fce000 r-xp /usr/lib/libctxdata.so.0.0.0
b4fd6000 b4fe4000 r-xp /usr/lib/libremix.so.0.0.0
b4fec000 b4fed000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4ff5000 b500e000 r-xp /usr/lib/liblua-5.1.so
b5017000 b501e000 r-xp /usr/lib/libembryo.so.1.7.99
b5027000 b5067000 r-xp /usr/lib/libcurl.so.4.3.0
b5070000 b50da000 r-xp /usr/lib/libpixman-1.so.0.28.2
b50e7000 b510b000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5114000 b5170000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5182000 b5196000 r-xp /usr/lib/libfribidi.so.0.3.1
b519e000 b51f6000 r-xp /usr/lib/libfreetype.so.6.8.1
b5201000 b5225000 r-xp /usr/lib/libjpeg.so.8.0.2
b523d000 b5254000 r-xp /lib/libz.so.1.2.5
b525c000 b5264000 r-xp /usr/lib/libemotion.so.1.7.99
b526c000 b5271000 r-xp /usr/lib/libecore_fb.so.1.7.99
b527a000 b5288000 r-xp /usr/lib/libsensor.so.1.1.0
b5294000 b529a000 r-xp /usr/lib/libappcore-common.so.1.1
b52a2000 b52a4000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.78
b52ac000 b52b5000 r-xp /usr/lib/libresourced.so.0.2.78
b52be000 b52c1000 r-xp /usr/lib/libproc-stat.so.0.2.78
b62be000 b63a6000 r-xp /usr/lib/libicuuc.so.48.1
b63b3000 b64d3000 r-xp /usr/lib/libicui18n.so.48.1
b64e1000 b64e4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b64ec000 b64f5000 r-xp /usr/lib/libvconf.so.0.2.45
b64fd000 b6503000 r-xp /usr/lib/libxdgmime.so.1.1.0
b650b000 b6517000 r-xp /usr/lib/libail.so.0.1.0
b651f000 b652a000 r-xp /usr/lib/libaul.so.0.1.0
b6532000 b6549000 r-xp /usr/lib/libecore_input.so.1.7.99
b6564000 b6581000 r-xp /usr/lib/libecore_evas.so.1.7.99
b658a000 b658c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6594000 b65c8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b65d1000 b6600000 r-xp /usr/lib/libecore_x.so.1.7.99
b660a000 b6649000 r-xp /usr/lib/libeina.so.1.7.99
b6652000 b6667000 r-xp /usr/lib/libecore.so.1.7.99
b667e000 b6699000 r-xp /usr/lib/libecore_con.so.1.7.99
b66a2000 b66a7000 r-xp /usr/lib/libecore_imf.so.1.7.99
b66af000 b66b7000 r-xp /usr/lib/libethumb_client.so.1.7.99
b66bf000 b66c8000 r-xp /usr/lib/libedbus.so.1.7.99
b66d0000 b66d2000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b66da000 b66de000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b66e7000 b66fd000 r-xp /usr/lib/libefreet.so.1.7.99
b6707000 b6763000 r-xp /usr/lib/libedje.so.1.7.99
b676d000 b681d000 r-xp /usr/lib/libevas.so.1.7.99
b683f000 b6852000 r-xp /usr/lib/libeet.so.1.7.99
b685b000 b68c5000 r-xp /lib/libm-2.13.so
b68ce000 b68d6000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.2
b68d7000 b68de000 r-xp /usr/lib/libutilX.so.1.1.0
b68e6000 b6a08000 r-xp /usr/lib/libelementary.so.1.7.99
b6a1d000 b6a20000 r-xp /lib/libattr.so.1.1.0
b6a28000 b6a2a000 r-xp /usr/lib/libXau.so.6.0.0
b6a32000 b6a38000 r-xp /lib/librt-2.13.so
b6a41000 b6a49000 r-xp /lib/libcrypt-2.13.so
b6a79000 b6a7c000 r-xp /lib/libcap.so.2.21
b6a84000 b6a86000 r-xp /usr/lib/libiri.so
b6a8e000 b6aa3000 r-xp /usr/lib/libxcb.so.1.1.0
b6aab000 b6ab6000 r-xp /lib/libunwind.so.8.0.1
b6ae4000 b6c01000 r-xp /lib/libc-2.13.so
b6c0f000 b6c18000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c20000 b6c4c000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c55000 b6c58000 r-xp /usr/lib/libbundle.so.0.1.22
b6c60000 b6c62000 r-xp /lib/libdl-2.13.so
b6c6b000 b6c6e000 r-xp /usr/lib/libsmack.so.1.0.0
b6c76000 b6d50000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d59000 b6d6d000 r-xp /lib/libpthread-2.13.so
b6d79000 b6d7e000 r-xp /usr/lib/libecore_file.so.1.7.99
b6d86000 b6d8e000 r-xp /usr/lib/libappcore-efl.so.1.1
b6d90000 b6d91000 r-xp /usr/lib/libdlog.so.0.0.0
b6d9a000 b6e07000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e11000 b6e1a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e22000 b6f08000 r-xp /usr/lib/libX11.so.6.3.0
b6f13000 b6f14000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f1c000 b6f20000 r-xp /usr/lib/libsys-assert.so
b6f28000 b6f45000 r-xp /lib/ld-2.13.so
bef8a000 befab000 rwxp [stack]
End of Maps Information

Callstack Information (PID:26673)
Call Stack Count: 33
 0: Tizen::Ui::_ControlImpl::GetFullScreenSizeInfo() + 0x53 (0xb3b379b4) [/usr/lib/osp/libosp-uifw.so] + 0x2a99b4
 1: Tizen::Ui::Control::Destroy() + 0x8 (0xb3b1bcb1) [/usr/lib/osp/libosp-uifw.so] + 0x28dcb1
 2: MyHondanaMainForm::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x158 (0xb2e977b4) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0xf7b4
 3: non-virtual thunk to MyHondanaMainForm::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x10 (0xb2e98380) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0x10380
 4: (0xb3beb557) [/usr/lib/osp/libosp-uifw.so] + 0x35d557
 5: Tizen::Base::Runtime::_Event::ProcessListeners(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x2bc (0xb4501649) [/usr/lib/osp/libosp-appfw.so] + 0x151649
 6: Tizen::Base::Runtime::_Event::Fire(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x36 (0xb4501883) [/usr/lib/osp/libosp-appfw.so] + 0x151883
 7: Tizen::Base::Runtime::_Event::Fire(Tizen::Base::Runtime::IEventArg&) + 0x84 (0xb4501975) [/usr/lib/osp/libosp-appfw.so] + 0x151975
 8: (0xb3ce015f) [/usr/lib/osp/libosp-uifw.so] + 0x45215f
 9: (0xb3be8df3) [/usr/lib/osp/libosp-uifw.so] + 0x35adf3
10: Tizen::Base::Runtime::_Event::ProcessListeners(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x2bc (0xb4501649) [/usr/lib/osp/libosp-appfw.so] + 0x151649
11: Tizen::Base::Runtime::_Event::Fire(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x36 (0xb4501883) [/usr/lib/osp/libosp-appfw.so] + 0x151883
12: Tizen::Base::Runtime::_Event::Fire(Tizen::Base::Runtime::IEventArg&) + 0x84 (0xb4501975) [/usr/lib/osp/libosp-appfw.so] + 0x151975
13: Tizen::Ui::Controls::_Button::FireActionEvent() + 0x26 (0xb3bf24b7) [/usr/lib/osp/libosp-uifw.so] + 0x3644b7
14: (0xb3bf503d) [/usr/lib/osp/libosp-uifw.so] + 0x36703d
15: Tizen::Ui::Controls::_Button::OnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0xe (0xb3bf04b3) [/usr/lib/osp/libosp-uifw.so] + 0x3624b3
16: Tizen::Ui::_ControlImpl::CallOnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0x21a (0xb3b3a00f) [/usr/lib/osp/libosp-uifw.so] + 0x2ac00f
17: Tizen::Ui::_ControlImpl::_PropagatedTouchEventListener::OnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0x20c (0xb3b41e49) [/usr/lib/osp/libosp-uifw.so] + 0x2b3e49
18: Tizen::Ui::_UiTouchEvent::FireListener(Tizen::Ui::_ITouchEventListener const*, Tizen::Ui::_Control const*, bool, bool&) + 0x1aa (0xb3b999c3) [/usr/lib/osp/libosp-uifw.so] + 0x30b9c3
19: Tizen::Ui::_UiTouchEvent::OnEventProcessing(Tizen::Ui::_Control const&, bool&) + 0x62 (0xb3b99dcf) [/usr/lib/osp/libosp-uifw.so] + 0x30bdcf
20: Tizen::Ui::_UiEvent::ProcessEvent(Tizen::Ui::_Control const&, bool&) + 0x32 (0xb3b8e477) [/usr/lib/osp/libosp-uifw.so] + 0x300477
21: Tizen::Ui::_UiEventManager::ProcessBubblingEvent(Tizen::Base::Collection::LinkedListT<Tizen::Base::_HandleT<Tizen::Ui::_Control> > const&, Tizen::Ui::_UiEvent const&, bool&) + 0x78 (0xb3b8ed51) [/usr/lib/osp/libosp-uifw.so] + 0x300d51
22: Tizen::Ui::_UiEventManager::ProcessEvent(Tizen::Ui::_UiEvent const&, bool&) + 0x1ec (0xb3b8efdd) [/usr/lib/osp/libosp-uifw.so] + 0x300fdd
23: Tizen::Ui::_UiEventManager::Fire(Tizen::Ui::_UiEvent const&) + 0x8a (0xb3b8f0bf) [/usr/lib/osp/libosp-uifw.so] + 0x3010bf
24: Tizen::Ui::_UiEventManager::SendEvent(Tizen::Ui::_UiEvent const&) + 0x6 (0xb3b8f14f) [/usr/lib/osp/libosp-uifw.so] + 0x30114f
25: (0xb3b7f213) [/usr/lib/osp/libosp-uifw.so] + 0x2f1213
26: (0xb3b828a3) [/usr/lib/osp/libosp-uifw.so] + 0x2f48a3
27: (0xb6659aad) [/usr/lib/libecore.so.1] + 0x7aad
28: (0xb665d153) [/usr/lib/libecore.so.1] + 0xb153
29: ecore_main_loop_begin + 0x30 (0xb665d575) [/usr/lib/libecore.so.1] + 0xb575
30: elm_run + 0x6 (0xb698f6db) [/usr/lib/libelementary.so.1] + 0xa96db
31: appcore_efl_main + 0x114 (0xb6d8c268) [/usr/lib/libappcore-efl.so.1] + 0x6268
32: app_efl_main + 0xc6 (0xb4284ed3) [/usr/lib/libcapi-appfw-application.so.0] + 0x9ed3
End of Call Stack

Package Information
Package Name: vMEuS5j7iC.MyHondana
Package ID : vMEuS5j7iC
Version: 1.0.0
Package Type: tpk
App Name: MyHondana
App ID: vMEuS5j7iC.MyHondana
Type: Application
Categories: (NULL)
