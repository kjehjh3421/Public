S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMG2
Build-Date: 2013.07.04 20:54:23

Crash Information
Process Name: MyHondana
PID: 16691
Date: 2013-07-12 11:50:30(GMT+0900)
Executable File Path: /opt/apps/docomo6003/bin/MyHondana
This process is multi-thread process
pid=16691 tid=16691
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 16691, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000e35c0
r2   = 0x00000078, r3   = 0xb46f9ba0
r4   = 0x00196b82, r5   = 0x000e35c0
r6   = 0x00000000, r7   = 0xb4527585
r8   = 0xbeaf0f40, r9   = 0xbeaf0fa4
r10  = 0x000e35c0, fp   = 0xbeaf0fc0
ip   = 0xb4703340, sp   = 0xbeaf0f20
lr   = 0xb46001cd, pc   = 0xb456a5d0
cpsr = 0x800f0030

Memory Information
MemTotal:  2063912 KB
MemFree:   1680552 KB
Buffers:     13192 KB
Cached:     113392 KB
VmPeak:     101664 KB
VmSize:     101660 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18160 KB
VmRSS:       18160 KB
VmData:       7316 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       64524 KB
VmPTE:          88 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00090000 rw-p [heap]
00090000 000fd000 rw-p [heap]
b12b1000 b12fd000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b1306000 b130b000 r-xp /usr/lib/libjson.so.0.0.1
b1313000 b1317000 r-xp /usr/lib/liblocation-pos-log.so
b131f000 b1331000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b1339000 b133b000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b1343000 b1348000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b1350000 b135b000 r-xp /usr/lib/libdrm-trusted.so.0.0.52
b1363000 b1365000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b136d000 b137a000 r-xp /usr/lib/libdrm-client.so.0.0.90
b1383000 b138b000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b13ad000 b13e4000 r-xp /usr/lib/libpulse.so.0.16.2
b13ec000 b1450000 r-xp /usr/lib/libasound.so.2.0.0
b145a000 b145d000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1466000 b146a000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b1473000 b1490000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b1498000 b149d000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b14a5000 b14d2000 r-xp /usr/lib/libSLP-location.so.0.0.0
b14db000 b14e4000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b14ec000 b14f0000 r-xp /usr/lib/libmmffile.so.0.0.0
b14f8000 b14ff000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b1508000 b1522000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b152a000 b1545000 r-xp /usr/lib/libmedia-service.so.1.0.0
b154d000 b1558000 r-xp /usr/lib/libmdm-common.so.1.0.37
b1560000 b156e000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.7
b1577000 b157e000 r-xp /usr/lib/libenchant.so.1.6.1
b1586000 b1589000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.8
b1592000 b159b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b15a4000 b15a8000 r-xp /usr/lib/libmmfsession.so.0.0.0
b15b1000 b15c0000 r-xp /usr/lib/libmmfsound.so.0.1.0
b15c8000 b15cd000 r-xp /usr/lib/libmemenv.so.1.1.0
b15d5000 b1613000 r-xp /usr/lib/libleveldb.so.1.1.0
b161c000 b1646000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b164f000 b1651000 r-xp /usr/lib/libsecfw.so
b1659000 b1662000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b166d000 b167c000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1684000 b169c000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b169e000 b16ab000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b16b4000 b16bd000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b16c5000 b1707000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b1710000 b17ac000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b17b8000 b17dd000 r-xp /usr/lib/libxslt.so.1.1.16
b17e6000 b17e8000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b17f0000 b17f8000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b1800000 b180b000 r-xp /usr/lib/libcapi-location-manager.so.0.1.12
b1813000 b1816000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b181e000 b1823000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b182b000 b1852000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.70
b185a000 b1870000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b1879000 b18b6000 r-xp /usr/lib/libmdm.so.1.0.63
b18be000 b18d3000 r-xp /usr/lib/libnetwork.so.0.0.0
b18db000 b18e4000 r-xp /usr/lib/libcapi-web-favorites.so
b18ec000 b2b44000 r-xp /usr/lib/libewebkit2.so.0.10.144.6
b2c37000 b2c8a000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2c93000 b2caa000 r-xp /usr/lib/libwifi-direct.so.0.0
b2cb2000 b2cba000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.7
b2cc2000 b2ccb000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b2cd3000 b2cdd000 r-xp /usr/lib/libcapi-network-connection.so.0.1.10
b2ce5000 b2d49000 r-xp /usr/lib/osp/libosp-web.so.1.2.2.0
b2d56000 b2e0b000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2e18000 b2e32000 r-xp /usr/lib/osp/libosp-json.so.1.2.2.0
b2e3b000 b2e59000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2e7a000 b2ec6000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana.exe
b2ed0000 b2f18000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2f20000 b2fb0000 r-xp /usr/lib/libCOREGL.so.3.0
b2fba000 b2fbd000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2fc5000 b2fcc000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2fd5000 b2fe4000 r-xp /usr/lib/libICE.so.6.3.0
b2fee000 b2ff3000 r-xp /usr/lib/libSM.so.6.0.1
b2ffb000 b2ffc000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3004000 b3006000 r-xp /usr/lib/libledplayer.so.0.1
b300e000 b3014000 r-xp /usr/lib/libxcb-render.so.0.0.0
b301c000 b301d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3026000 b302d000 r-xp /usr/lib/libGLESv2.so.2.0
b3035000 b307c000 r-xp /usr/lib/libtiff.so.5.1.0
b3087000 b30b0000 r-xp /usr/lib/libturbojpeg.so
b30c9000 b30cd000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b30d6000 b30dc000 r-xp /usr/lib/libgif.so.4.1.6
b30e4000 b3106000 r-xp /usr/lib/libavutil.so.51.73.101
b3115000 b3143000 r-xp /usr/lib/libswscale.so.2.1.101
b314c000 b3443000 r-xp /usr/lib/libavcodec.so.54.59.100
b376a000 b3783000 r-xp /usr/lib/libpng12.so.0.50.0
b378c000 b3793000 r-xp /usr/lib/libfeedback.so.0.1.4
b379c000 b37af000 r-xp /usr/lib/libtts.so
b37b8000 b37ba000 r-xp /usr/lib/libEGL.so.1.4
b37c2000 b3879000 r-xp /usr/lib/libcairo.so.2.11200.12
b3883000 b389c000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b38a6000 b38aa000 r-xp /usr/lib/libss-client.so.1.0.0
b38b3000 b38b5000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana
b38bd000 b4169000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b41da000 b41e3000 r-xp /usr/lib/libslp_devman_plugin.so
b41ec000 b41ee000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b41f6000 b41f9000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b4201000 b4204000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b420c000 b4219000 r-xp /usr/lib/libmodem.so.0.0.0
b4221000 b4224000 r-xp /usr/lib/libdevice-node.so.0.1
b422c000 b423c000 r-xp /usr/lib/libaccounts-svc.so.0.2.68
b4244000 b4247000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b424f000 b4255000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b425d000 b4262000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b426a000 b426b000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b4274000 b4277000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b427f000 b4284000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b428c000 b428f000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b4297000 b4298000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b42a0000 b42ae000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b42b7000 b42bd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b42c5000 b42ea000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b42f2000 b42f5000 r-xp /usr/lib/libuuid.so.1.3.0
b42fe000 b4312000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b431a000 b4322000 r-xp /usr/lib/libminizip.so.1.0.0
b432a000 b4336000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b433f000 b435d000 r-xp /usr/lib/libpcre.so.0.0.1
b4365000 b4369000 r-xp /usr/lib/libheynoti.so.0.0.2
b4371000 b437f000 r-xp /usr/lib/libdeviced.so.0.1.0
b4388000 b4393000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b43a0000 b43a9000 r-xp /usr/lib/libdevman.so.0.1
b43b1000 b43b5000 r-xp /usr/lib/libchromium.so.1.0
b43bd000 b43ce000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.4
b43d7000 b46e3000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b470b000 b4715000 r-xp /lib/libnss_files-2.13.so
b471e000 b471f000 r-xp /usr/lib/libpmapi.so.1.2
b4727000 b472e000 r-xp /usr/lib/libalarm.so.0.0.0
b4736000 b4749000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b4752000 b476e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b4777000 b477a000 r-xp /usr/lib/libiniparser.so.0
b4783000 b47d3000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b47dd000 b47ee000 r-xp /usr/lib/libcom-core.so.0.0.1
b47f6000 b47fc000 r-xp /usr/lib/libappsvc.so.0.1.0
b4804000 b4806000 r-xp /usr/lib/libdri2.so.0.0.0
b480e000 b4816000 r-xp /usr/lib/libdrm.so.2.4.0
b481e000 b4822000 r-xp /usr/lib/libtbm.so.1.0.0
b482a000 b482d000 r-xp /usr/lib/libXv.so.1.0.0
b4835000 b483f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4848000 b4914000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b492a000 b4939000 r-xp /usr/lib/libnotification.so.0.1.0
b4941000 b4965000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b496e000 b497e000 r-xp /lib/libresolv-2.13.so
b4982000 b4984000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b498c000 b4a64000 r-xp /usr/lib/libxml2.so.2.7.8
b4a71000 b4b4e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4b59000 b4b5e000 r-xp /usr/lib/libcheck.so.0.0.0
b4b66000 b4b70000 r-xp /usr/lib/libspdy.so.0.0.0
b4b79000 b4ccc000 r-xp /usr/lib/libcrypto.so.1.0.0
b4cea000 b4d36000 r-xp /usr/lib/libssl.so.1.0.0
b4d42000 b4d70000 r-xp /usr/lib/libidn.so.11.5.44
b4d79000 b4d83000 r-xp /usr/lib/libcares.so.2.1.0
b4d8b000 b4da2000 r-xp /lib/libexpat.so.1.5.2
b4dac000 b4dd0000 r-xp /usr/lib/libicule.so.48.1
b4dd9000 b4de7000 r-xp /usr/lib/libsf_common.so
b4df0000 b4e8b000 r-xp /usr/lib/libstdc++.so.6.0.14
b4e9e000 b4eb6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4eb7000 b4eba000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4ec2000 b4ec6000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4ecf000 b4ed4000 r-xp /usr/lib/libffi.so.5.0.10
b4edc000 b4edd000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4ee5000 b4eef000 r-xp /usr/lib/libXext.so.6.4.0
b4ef8000 b4efb000 r-xp /usr/lib/libXtst.so.6.1.0
b4f03000 b4f09000 r-xp /usr/lib/libXrender.so.1.3.0
b4f11000 b4f17000 r-xp /usr/lib/libXrandr.so.2.2.0
b4f1f000 b4f20000 r-xp /usr/lib/libXinerama.so.1.0.0
b4f29000 b4f32000 r-xp /usr/lib/libXi.so.6.1.0
b4f3a000 b4f3d000 r-xp /usr/lib/libXfixes.so.3.1.0
b4f45000 b4f47000 r-xp /usr/lib/libXgesture.so.7.0.0
b4f4f000 b4f50000 r-xp /usr/lib/libXdamage.so.1.1.0
b4f59000 b4f60000 r-xp /usr/lib/libXcursor.so.1.0.2
b4f68000 b4f8b000 r-xp /usr/lib/libexif.so.12.3.3
b4f9f000 b4fa9000 r-xp /usr/lib/libethumb.so.1.7.99
b4fb1000 b4ff5000 r-xp /usr/lib/libsndfile.so.1.0.25
b5003000 b5005000 r-xp /usr/lib/libctxdata.so.0.0.0
b500d000 b501b000 r-xp /usr/lib/libremix.so.0.0.0
b5023000 b5024000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b502c000 b5045000 r-xp /usr/lib/liblua-5.1.so
b504e000 b5055000 r-xp /usr/lib/libembryo.so.1.7.99
b505e000 b509e000 r-xp /usr/lib/libcurl.so.4.3.0
b50a7000 b5111000 r-xp /usr/lib/libpixman-1.so.0.28.2
b511e000 b5142000 r-xp /usr/lib/libfontconfig.so.1.5.0
b514b000 b51a7000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b51b9000 b51cd000 r-xp /usr/lib/libfribidi.so.0.3.1
b51d5000 b522d000 r-xp /usr/lib/libfreetype.so.6.8.1
b5238000 b525c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5274000 b528b000 r-xp /lib/libz.so.1.2.5
b5293000 b529b000 r-xp /usr/lib/libemotion.so.1.7.99
b52a3000 b52a8000 r-xp /usr/lib/libecore_fb.so.1.7.99
b52b1000 b52bf000 r-xp /usr/lib/libsensor.so.1.1.0
b52cb000 b52d1000 r-xp /usr/lib/libappcore-common.so.1.1
b52d9000 b52db000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.79
b52e3000 b52ee000 r-xp /usr/lib/libresourced.so.0.2.79
b52f6000 b52f9000 r-xp /usr/lib/libproc-stat.so.0.2.79
b62f6000 b63de000 r-xp /usr/lib/libicuuc.so.48.1
b63eb000 b650b000 r-xp /usr/lib/libicui18n.so.48.1
b6519000 b651c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6524000 b652c000 r-xp /usr/lib/libvconf.so.0.2.45
b6534000 b653a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6542000 b654e000 r-xp /usr/lib/libail.so.0.1.0
b6556000 b6561000 r-xp /usr/lib/libaul.so.0.1.0
b656a000 b6581000 r-xp /usr/lib/libecore_input.so.1.7.99
b659c000 b65b9000 r-xp /usr/lib/libecore_evas.so.1.7.99
b65c2000 b65c4000 r-xp /usr/lib/libXcomposite.so.1.0.0
b65cc000 b6600000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6609000 b6638000 r-xp /usr/lib/libecore_x.so.1.7.99
b6642000 b6681000 r-xp /usr/lib/libeina.so.1.7.99
b668a000 b669f000 r-xp /usr/lib/libecore.so.1.7.99
b66b6000 b66d1000 r-xp /usr/lib/libecore_con.so.1.7.99
b66da000 b66df000 r-xp /usr/lib/libecore_imf.so.1.7.99
b66e7000 b66ef000 r-xp /usr/lib/libethumb_client.so.1.7.99
b66f7000 b6700000 r-xp /usr/lib/libedbus.so.1.7.99
b6708000 b670a000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b6712000 b6716000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b671f000 b6735000 r-xp /usr/lib/libefreet.so.1.7.99
b673f000 b679b000 r-xp /usr/lib/libedje.so.1.7.99
b67a5000 b6855000 r-xp /usr/lib/libevas.so.1.7.99
b6877000 b688a000 r-xp /usr/lib/libeet.so.1.7.99
b6893000 b68fd000 r-xp /lib/libm-2.13.so
b6906000 b690e000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.2
b690f000 b6916000 r-xp /usr/lib/libutilX.so.1.1.0
b691e000 b6a40000 r-xp /usr/lib/libelementary.so.1.7.99
b6a55000 b6a58000 r-xp /lib/libattr.so.1.1.0
b6a60000 b6a62000 r-xp /usr/lib/libXau.so.6.0.0
b6a6a000 b6a70000 r-xp /lib/librt-2.13.so
b6a79000 b6a81000 r-xp /lib/libcrypt-2.13.so
b6ab1000 b6ab4000 r-xp /lib/libcap.so.2.21
b6abc000 b6abe000 r-xp /usr/lib/libiri.so
b6ac6000 b6adb000 r-xp /usr/lib/libxcb.so.1.1.0
b6ae3000 b6aee000 r-xp /lib/libunwind.so.8.0.1
b6b1c000 b6c39000 r-xp /lib/libc-2.13.so
b6c47000 b6c50000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c58000 b6c84000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c8d000 b6c90000 r-xp /usr/lib/libbundle.so.0.1.22
b6c98000 b6c9a000 r-xp /lib/libdl-2.13.so
b6ca3000 b6ca6000 r-xp /usr/lib/libsmack.so.1.0.0
b6cae000 b6d88000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d91000 b6da5000 r-xp /lib/libpthread-2.13.so
b6db1000 b6db6000 r-xp /usr/lib/libecore_file.so.1.7.99
b6dbe000 b6dc6000 r-xp /usr/lib/libappcore-efl.so.1.1
b6dc8000 b6dc9000 r-xp /usr/lib/libdlog.so.0.0.0
b6dd2000 b6e3f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e49000 b6e52000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e5a000 b6f40000 r-xp /usr/lib/libX11.so.6.3.0
b6f4b000 b6f4c000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f54000 b6f58000 r-xp /usr/lib/libsys-assert.so
b6f60000 b6f7d000 r-xp /lib/ld-2.13.so
bead2000 beaf3000 rwxp [stack]
End of Maps Information

Callstack Information (PID:16691)
Call Stack Count: 23
 0: Tizen::Io::_IpcClient::SendRequest(IPC::Message const&) + 0x7 (0xb456a5d0) [/usr/lib/osp/libosp-appfw.so] + 0x1935d0
 1: (0xb46001cd) [/usr/lib/osp/libosp-appfw.so] + 0x2291cd
 2: (0xb46006d1) [/usr/lib/osp/libosp-appfw.so] + 0x2296d1
 3: Tizen::System::_SettingInfoImpl::AddSettingEventListenerForInternal(Tizen::System::ISettingEventListener&) + 0x1a (0xb45f914f) [/usr/lib/osp/libosp-appfw.so] + 0x22214f
 4: (0xb3b4a3e1) [/usr/lib/osp/libosp-uifw.so] + 0x28d3e1
 5: Tizen::Ui::_AccessibilityManager::Initialize() + 0x5e (0xb3b42533) [/usr/lib/osp/libosp-uifw.so] + 0x285533
 6: Tizen::Ui::_AccessibilityManager::_AccessibilityManager() + 0x15a (0xb3b4287f) [/usr/lib/osp/libosp-uifw.so] + 0x28587f
 7: Tizen::Ui::_AccessibilityManager::InitializeInstance() + 0x18 (0xb3b42905) [/usr/lib/osp/libosp-uifw.so] + 0x285905
 8: pthread_once + 0xc8 (0xb6d9dab0) [/lib/libpthread.so.0] + 0xcab0
 9: Tizen::Ui::_AccessibilityManager::CreateInstance() + 0x1a (0xb3b4645b) [/usr/lib/osp/libosp-uifw.so] + 0x28945b
10: Tizen::Ui::_ControlManager::_ControlManager() + 0x21c (0xb3b77d51) [/usr/lib/osp/libosp-uifw.so] + 0x2bad51
11: Tizen::Ui::_ControlManager::InitInstance() + 0x22 (0xb3b77eeb) [/usr/lib/osp/libosp-uifw.so] + 0x2baeeb
12: pthread_once + 0xc8 (0xb6d9dab0) [/lib/libpthread.so.0] + 0xcab0
13: Tizen::Ui::_ControlManager::Initialize() + 0x66 (0xb3b7a177) [/usr/lib/osp/libosp-uifw.so] + 0x2bd177
14: (0xb3b7c53f) [/usr/lib/osp/libosp-uifw.so] + 0x2bf53f
15: InitializeUiFramework + 0x6 (0xb3b7c56f) [/usr/lib/osp/libosp-uifw.so] + 0x2bf56f
16: Tizen::App::_UiAppImpl::OnAppInitializing() + 0xc (0xb3f253d9) [/usr/lib/osp/libosp-uifw.so] + 0x6683d9
17: Tizen::App::_AppImpl::OnCreate(void*) + 0x80 (0xb44c9c85) [/usr/lib/osp/libosp-appfw.so] + 0xf2c85
18: (0xb42a9d7f) [/usr/lib/libcapi-appfw-application.so.0] + 0x9d7f
19: (0xb6dc296c) [/usr/lib/libappcore-efl.so.1] + 0x496c
20: appcore_efl_main + 0xe8 (0xb6dc423c) [/usr/lib/libappcore-efl.so.1] + 0x623c
21: app_efl_main + 0xc6 (0xb42a9ed3) [/usr/lib/libcapi-appfw-application.so.0] + 0x9ed3
22: (0xb42b55e8) [/usr/lib/libcapi-appfw-application.so.0] + 0xb42b55e8
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
