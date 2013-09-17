S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMG1
Build-Date: 2013.07.02 01:59:30

Crash Information
Process Name: MyHondana
PID: 11548
Date: 2013-07-04 17:22:42(GMT+0900)
Executable File Path: /opt/apps/docomo6003/bin/MyHondana
This process is multi-thread process
pid=11548 tid=11548
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 11548, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000001
r2   = 0xbe899688, r3   = 0xb2e7add8
r4   = 0x001b7c94, r5   = 0x00000430
r6   = 0x00000001, r7   = 0xbe8994ac
r8   = 0x00006738, r9   = 0xbe899688
r10  = 0x00007838, fp   = 0xbe899478
ip   = 0xb41904ac, sp   = 0xbe899450
lr   = 0xb3b0d277, pc   = 0xb3b27408
cpsr = 0x68070030

Memory Information
MemTotal:  2063912 KB
MemFree:    954556 KB
Buffers:     71664 KB
Cached:     674752 KB
VmPeak:     155412 KB
VmSize:     135404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       49436 KB
VmRSS:       49436 KB
VmData:      33820 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       66032 KB
VmPTE:         138 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00072000 rw-p [heap]
00072000 0124a000 rw-p [heap]
b059c000 b05a0000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b05a9000 b0da8000 rwxp [stack:11550]
b0da8000 b0ef6000 r-xp /usr/lib/r3p2/libMali.so
b0f02000 b0f2a000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0f2e000 b0f4c000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b0f5e000 b0f64000 r-xp /usr/lib/libUMP.so
b12a6000 b12f2000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b12fb000 b1300000 r-xp /usr/lib/libjson.so.0.0.1
b1308000 b130c000 r-xp /usr/lib/liblocation-pos-log.so
b1314000 b131f000 r-xp /usr/lib/libmdm-common.so.1.0.37
b1327000 b1339000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b1341000 b1343000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b134b000 b1350000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b1358000 b1363000 r-xp /usr/lib/libdrm-trusted.so.0.0.52
b136b000 b136d000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b1375000 b1382000 r-xp /usr/lib/libdrm-client.so.0.0.90
b138b000 b1393000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b13b5000 b13ec000 r-xp /usr/lib/libpulse.so.0.16.2
b13f4000 b1458000 r-xp /usr/lib/libasound.so.2.0.0
b1462000 b1465000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b146e000 b1472000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b147b000 b1498000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b14a0000 b14a5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b14ad000 b14da000 r-xp /usr/lib/libSLP-location.so.0.0.0
b14e3000 b1520000 r-xp /usr/lib/libmdm.so.1.0.63
b1528000 b152c000 r-xp /usr/lib/libss-client.so.1.0.0
b1535000 b153e000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b1546000 b154a000 r-xp /usr/lib/libmmffile.so.0.0.0
b1552000 b1559000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b1562000 b157c000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b1584000 b159f000 r-xp /usr/lib/libmedia-service.so.1.0.0
b15a7000 b15bc000 r-xp /usr/lib/libnetwork.so.0.0.0
b15c4000 b15d2000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.7
b15db000 b15e2000 r-xp /usr/lib/libenchant.so.1.6.1
b15ea000 b15ed000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.8
b15f6000 b15ff000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b1608000 b160c000 r-xp /usr/lib/libmmfsession.so.0.0.0
b1615000 b1624000 r-xp /usr/lib/libmmfsound.so.0.1.0
b162c000 b1631000 r-xp /usr/lib/libmemenv.so.1.1.0
b1639000 b1677000 r-xp /usr/lib/libleveldb.so.1.1.0
b1680000 b16aa000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b16b3000 b16b5000 r-xp /usr/lib/libsecfw.so
b16bd000 b16c6000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b16d1000 b16e0000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b16e8000 b1700000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b1702000 b170f000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b1718000 b1721000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b1729000 b176b000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b1774000 b1810000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b181c000 b1841000 r-xp /usr/lib/libxslt.so.1.1.16
b184a000 b184c000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b1854000 b185c000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b1864000 b186f000 r-xp /usr/lib/libcapi-location-manager.so.0.1.12
b1877000 b188e000 r-xp /usr/lib/libwifi-direct.so.0.0
b1896000 b189e000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.7
b18a6000 b18af000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b18b7000 b18ba000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b18c2000 b18e9000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.70
b18f1000 b1907000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b1910000 b191a000 r-xp /usr/lib/libcapi-network-connection.so.0.1.10
b1922000 b192b000 r-xp /usr/lib/libcapi-web-favorites.so
b1933000 b2b8b000 r-xp /usr/lib/libewebkit2.so.0.10.144.4
b2c77000 b2d2c000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2d39000 b2d57000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2d60000 b2d7a000 r-xp /usr/lib/osp/libosp-json.so.1.2.1.0
b2d83000 b2dd6000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2ddf000 b2e43000 r-xp /usr/lib/osp/libosp-web.so.1.2.2.0
b2e56000 b2e60000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2e68000 b2e85000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana.exe
b2e8f000 b2ed7000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2edf000 b2f6f000 r-xp /usr/lib/libCOREGL.so.3.0
b2f79000 b2f7c000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2f84000 b2f8b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2f94000 b2fa3000 r-xp /usr/lib/libICE.so.6.3.0
b2fad000 b2fb2000 r-xp /usr/lib/libSM.so.6.0.1
b2fba000 b2fbb000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2fc3000 b2fc5000 r-xp /usr/lib/libledplayer.so.0.1
b2fcd000 b2fd3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2fdb000 b2fdc000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2fe5000 b2fec000 r-xp /usr/lib/libGLESv2.so.2.0
b2ff4000 b303b000 r-xp /usr/lib/libtiff.so.5.1.0
b3046000 b306f000 r-xp /usr/lib/libturbojpeg.so
b3088000 b308c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3095000 b309b000 r-xp /usr/lib/libgif.so.4.1.6
b30a3000 b30c5000 r-xp /usr/lib/libavutil.so.51.73.101
b30d4000 b3102000 r-xp /usr/lib/libswscale.so.2.1.101
b310b000 b3402000 r-xp /usr/lib/libavcodec.so.54.59.100
b3729000 b3742000 r-xp /usr/lib/libpng12.so.0.50.0
b374b000 b3752000 r-xp /usr/lib/libfeedback.so.0.1.4
b375b000 b376e000 r-xp /usr/lib/libtts.so
b3777000 b3779000 r-xp /usr/lib/libEGL.so.1.4
b3781000 b3838000 r-xp /usr/lib/libcairo.so.2.11200.12
b3842000 b385b000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3865000 b386a000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b3872000 b3874000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana
b387c000 b4128000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b4199000 b41a2000 r-xp /usr/lib/libslp_devman_plugin.so
b41ab000 b41ad000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b41b5000 b41b8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b41c0000 b41c3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b41cb000 b41d8000 r-xp /usr/lib/libmodem.so.0.0.0
b41e0000 b41e3000 r-xp /usr/lib/libdevice-node.so.0.1
b41eb000 b41fb000 r-xp /usr/lib/libaccounts-svc.so.0.2.68
b4203000 b4206000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b420e000 b4214000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b421c000 b4221000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b4229000 b422a000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b4233000 b4236000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b423e000 b4243000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b424b000 b424e000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b4256000 b4257000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b425f000 b426d000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b4276000 b427c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b4284000 b42a9000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b42b1000 b42b4000 r-xp /usr/lib/libuuid.so.1.3.0
b42bd000 b42d1000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b42d9000 b42e1000 r-xp /usr/lib/libminizip.so.1.0.0
b42e9000 b42f5000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b42fe000 b431c000 r-xp /usr/lib/libpcre.so.0.0.1
b4324000 b4328000 r-xp /usr/lib/libheynoti.so.0.0.2
b4330000 b433e000 r-xp /usr/lib/libdeviced.so.0.1.0
b4347000 b4352000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b435f000 b4368000 r-xp /usr/lib/libdevman.so.0.1
b4370000 b4374000 r-xp /usr/lib/libchromium.so.1.0
b437c000 b438d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.4
b4396000 b46a2000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b46ca000 b46d4000 r-xp /lib/libnss_files-2.13.so
b46dd000 b46de000 r-xp /usr/lib/libpmapi.so.1.2
b46e6000 b46ed000 r-xp /usr/lib/libalarm.so.0.0.0
b46f5000 b4708000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b4711000 b472d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b4736000 b4739000 r-xp /usr/lib/libiniparser.so.0
b4742000 b4792000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b479c000 b47ad000 r-xp /usr/lib/libcom-core.so.0.0.1
b47b5000 b47bb000 r-xp /usr/lib/libappsvc.so.0.1.0
b47c3000 b47c5000 r-xp /usr/lib/libdri2.so.0.0.0
b47cd000 b47d5000 r-xp /usr/lib/libdrm.so.2.4.0
b47dd000 b47e1000 r-xp /usr/lib/libtbm.so.1.0.0
b47e9000 b47ec000 r-xp /usr/lib/libXv.so.1.0.0
b47f4000 b47fe000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4807000 b48d3000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b48e9000 b48f8000 r-xp /usr/lib/libnotification.so.0.1.0
b4900000 b4924000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b492d000 b493d000 r-xp /lib/libresolv-2.13.so
b4941000 b4943000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b494b000 b4a23000 r-xp /usr/lib/libxml2.so.2.7.8
b4a30000 b4b0d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4b18000 b4b1d000 r-xp /usr/lib/libcheck.so.0.0.0
b4b25000 b4b2f000 r-xp /usr/lib/libspdy.so.0.0.0
b4b38000 b4c8b000 r-xp /usr/lib/libcrypto.so.1.0.0
b4ca9000 b4cf5000 r-xp /usr/lib/libssl.so.1.0.0
b4d01000 b4d2f000 r-xp /usr/lib/libidn.so.11.5.44
b4d38000 b4d42000 r-xp /usr/lib/libcares.so.2.1.0
b4d4a000 b4d61000 r-xp /lib/libexpat.so.1.5.2
b4d6b000 b4d8f000 r-xp /usr/lib/libicule.so.48.1
b4d98000 b4da6000 r-xp /usr/lib/libsf_common.so
b4daf000 b4e4a000 r-xp /usr/lib/libstdc++.so.6.0.14
b4e5d000 b4e75000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4e76000 b4e79000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4e81000 b4e85000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4e8e000 b4e93000 r-xp /usr/lib/libffi.so.5.0.10
b4e9b000 b4e9c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4ea4000 b4eae000 r-xp /usr/lib/libXext.so.6.4.0
b4eb7000 b4eba000 r-xp /usr/lib/libXtst.so.6.1.0
b4ec2000 b4ec8000 r-xp /usr/lib/libXrender.so.1.3.0
b4ed0000 b4ed6000 r-xp /usr/lib/libXrandr.so.2.2.0
b4ede000 b4edf000 r-xp /usr/lib/libXinerama.so.1.0.0
b4ee8000 b4ef1000 r-xp /usr/lib/libXi.so.6.1.0
b4ef9000 b4efc000 r-xp /usr/lib/libXfixes.so.3.1.0
b4f04000 b4f06000 r-xp /usr/lib/libXgesture.so.7.0.0
b4f0e000 b4f0f000 r-xp /usr/lib/libXdamage.so.1.1.0
b4f18000 b4f1f000 r-xp /usr/lib/libXcursor.so.1.0.2
b4f27000 b4f4a000 r-xp /usr/lib/libexif.so.12.3.3
b4f5e000 b4f68000 r-xp /usr/lib/libethumb.so.1.7.99
b4f70000 b4fb4000 r-xp /usr/lib/libsndfile.so.1.0.25
b4fc2000 b4fc4000 r-xp /usr/lib/libctxdata.so.0.0.0
b4fcc000 b4fda000 r-xp /usr/lib/libremix.so.0.0.0
b4fe2000 b4fe3000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4feb000 b5004000 r-xp /usr/lib/liblua-5.1.so
b500d000 b5014000 r-xp /usr/lib/libembryo.so.1.7.99
b501d000 b505d000 r-xp /usr/lib/libcurl.so.4.3.0
b5066000 b50d0000 r-xp /usr/lib/libpixman-1.so.0.28.2
b50dd000 b5101000 r-xp /usr/lib/libfontconfig.so.1.5.0
b510a000 b5166000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5178000 b518c000 r-xp /usr/lib/libfribidi.so.0.3.1
b5194000 b51ec000 r-xp /usr/lib/libfreetype.so.6.8.1
b51f7000 b521b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5233000 b524a000 r-xp /lib/libz.so.1.2.5
b5252000 b525a000 r-xp /usr/lib/libemotion.so.1.7.99
b5262000 b5267000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5270000 b527e000 r-xp /usr/lib/libsensor.so.1.1.0
b528a000 b5290000 r-xp /usr/lib/libappcore-common.so.1.1
b5298000 b529a000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.79
b52a2000 b52ad000 r-xp /usr/lib/libresourced.so.0.2.79
b52b5000 b52b8000 r-xp /usr/lib/libproc-stat.so.0.2.79
b62b5000 b639d000 r-xp /usr/lib/libicuuc.so.48.1
b63aa000 b64ca000 r-xp /usr/lib/libicui18n.so.48.1
b64d8000 b64db000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b64e3000 b64eb000 r-xp /usr/lib/libvconf.so.0.2.45
b64f3000 b64f9000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6501000 b650d000 r-xp /usr/lib/libail.so.0.1.0
b6515000 b6520000 r-xp /usr/lib/libaul.so.0.1.0
b6529000 b6540000 r-xp /usr/lib/libecore_input.so.1.7.99
b655b000 b6578000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6581000 b6583000 r-xp /usr/lib/libXcomposite.so.1.0.0
b658b000 b65bf000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b65c8000 b65f7000 r-xp /usr/lib/libecore_x.so.1.7.99
b6601000 b6640000 r-xp /usr/lib/libeina.so.1.7.99
b6649000 b665e000 r-xp /usr/lib/libecore.so.1.7.99
b6675000 b6690000 r-xp /usr/lib/libecore_con.so.1.7.99
b6699000 b669e000 r-xp /usr/lib/libecore_imf.so.1.7.99
b66a6000 b66ae000 r-xp /usr/lib/libethumb_client.so.1.7.99
b66b6000 b66bf000 r-xp /usr/lib/libedbus.so.1.7.99
b66c7000 b66c9000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b66d1000 b66d5000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b66de000 b66f4000 r-xp /usr/lib/libefreet.so.1.7.99
b66fe000 b675a000 r-xp /usr/lib/libedje.so.1.7.99
b6764000 b6814000 r-xp /usr/lib/libevas.so.1.7.99
b6836000 b6849000 r-xp /usr/lib/libeet.so.1.7.99
b6852000 b68bc000 r-xp /lib/libm-2.13.so
b68c5000 b68cd000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.2
b68ce000 b68d5000 r-xp /usr/lib/libutilX.so.1.1.0
b68dd000 b69ff000 r-xp /usr/lib/libelementary.so.1.7.99
b6a14000 b6a17000 r-xp /lib/libattr.so.1.1.0
b6a1f000 b6a21000 r-xp /usr/lib/libXau.so.6.0.0
b6a29000 b6a2f000 r-xp /lib/librt-2.13.so
b6a38000 b6a40000 r-xp /lib/libcrypt-2.13.so
b6a70000 b6a73000 r-xp /lib/libcap.so.2.21
b6a7b000 b6a7d000 r-xp /usr/lib/libiri.so
b6a85000 b6a9a000 r-xp /usr/lib/libxcb.so.1.1.0
b6aa2000 b6aad000 r-xp /lib/libunwind.so.8.0.1
b6adb000 b6bf8000 r-xp /lib/libc-2.13.so
b6c06000 b6c0f000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c17000 b6c43000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c4c000 b6c4f000 r-xp /usr/lib/libbundle.so.0.1.22
b6c57000 b6c59000 r-xp /lib/libdl-2.13.so
b6c62000 b6c65000 r-xp /usr/lib/libsmack.so.1.0.0
b6c6d000 b6d47000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d50000 b6d64000 r-xp /lib/libpthread-2.13.so
b6d70000 b6d75000 r-xp /usr/lib/libecore_file.so.1.7.99
b6d7d000 b6d85000 r-xp /usr/lib/libappcore-efl.so.1.1
b6d87000 b6d88000 r-xp /usr/lib/libdlog.so.0.0.0
b6d91000 b6dfe000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e08000 b6e11000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e19000 b6eff000 r-xp /usr/lib/libX11.so.6.3.0
b6f0a000 b6f0b000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f13000 b6f17000 r-xp /usr/lib/libsys-assert.so
b6f1f000 b6f3c000 r-xp /lib/ld-2.13.so
be87a000 be89b000 rwxp [stack]
End of Maps Information

Callstack Information (PID:11548)
Call Stack Count: 21
 0: Tizen::Ui::_ControlImpl::GetFullScreenSizeInfo() + 0x53 (0xb3b27408) [/usr/lib/osp/libosp-uifw.so] + 0x2ab408
 1: Tizen::Ui::Control::SetShowState(bool) + 0xa (0xb3b0d277) [/usr/lib/osp/libosp-uifw.so] + 0x291277
 2: non-virtual thunk to MyHondanaMainForm::OnFormMenuRequested(Tizen::Ui::Controls::Form&) + 0x4c (0xb2e7ae24) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x12e24
 3: Tizen::Ui::Controls::_FormImpl::OnFormMenuRequested(Tizen::Ui::Controls::_Form&) + 0x26 (0xb3ce288f) [/usr/lib/osp/libosp-uifw.so] + 0x46688f
 4: Tizen::Ui::Controls::_Form::OnKeyReleased(Tizen::Ui::_Control const&, Tizen::Ui::_KeyInfo const&) + 0x44 (0xb3c490b1) [/usr/lib/osp/libosp-uifw.so] + 0x3cd0b1
 5: Tizen::Ui::_ControlImpl::_PropagatedKeyEventListener::OnKeyReleased(Tizen::Ui::_Control const&, Tizen::Ui::_KeyInfo const&) + 0xa0 (0xb3b31a21) [/usr/lib/osp/libosp-uifw.so] + 0x2b5a21
 6: (0xb3b8840f) [/usr/lib/osp/libosp-uifw.so] + 0x30c40f
 7: (0xb3b884f9) [/usr/lib/osp/libosp-uifw.so] + 0x30c4f9
 8: Tizen::Ui::_UiEvent::ProcessEvent(Tizen::Ui::_Control const&, bool&) + 0x32 (0xb3b7dee3) [/usr/lib/osp/libosp-uifw.so] + 0x301ee3
 9: Tizen::Ui::_UiEventManager::ProcessBubblingEvent(Tizen::Base::Collection::LinkedListT<Tizen::Base::_HandleT<Tizen::Ui::_Control> > const&, Tizen::Ui::_UiEvent const&, bool&) + 0x6c (0xb3b7e7b1) [/usr/lib/osp/libosp-uifw.so] + 0x3027b1
10: Tizen::Ui::_UiEventManager::ProcessEvent(Tizen::Ui::_UiEvent const&, bool&) + 0x1ec (0xb3b7ea09) [/usr/lib/osp/libosp-uifw.so] + 0x302a09
11: Tizen::Ui::_UiEventManager::Fire(Tizen::Ui::_UiEvent const&) + 0xae (0xb3b7eb0f) [/usr/lib/osp/libosp-uifw.so] + 0x302b0f
12: Tizen::Ui::_UiEventManager::SendEvent(Tizen::Ui::_UiEvent const&) + 0x6 (0xb3b7eb7b) [/usr/lib/osp/libosp-uifw.so] + 0x302b7b
13: (0xb3b6f407) [/usr/lib/osp/libosp-uifw.so] + 0x2f3407
14: (0xb3b70c1b) [/usr/lib/osp/libosp-uifw.so] + 0x2f4c1b
15: (0xb6650aad) [/usr/lib/libecore.so.1] + 0x7aad
16: (0xb6654153) [/usr/lib/libecore.so.1] + 0xb153
17: ecore_main_loop_begin + 0x30 (0xb6654575) [/usr/lib/libecore.so.1] + 0xb575
18: elm_run + 0x6 (0xb6986c73) [/usr/lib/libelementary.so.1] + 0xa9c73
19: appcore_efl_main + 0x114 (0xb6d83268) [/usr/lib/libappcore-efl.so.1] + 0x6268
20: app_efl_main + 0xc6 (0xb4268ed3) [/usr/lib/libcapi-appfw-application.so.0] + 0x9ed3
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
