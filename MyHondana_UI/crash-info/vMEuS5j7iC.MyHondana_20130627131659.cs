S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMF4
Build-Date: 2013.06.25 21:23:12

Crash Information
Process Name: MyHondana
PID: 5855
Date: 2013-06-27 13:16:59(GMT+0900)
Executable File Path: /opt/apps/vMEuS5j7iC/bin/MyHondana
This process is multi-thread process
pid=5855 tid=5855
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5855, uid 5000)
      TIMER: -2

Register Information
r0   = 0x00000000, r1   = 0x001b5740
r2   = 0x042f7600, r3   = 0xb3d074f1
r4   = 0x001b5718, r5   = 0x001b5740
r6   = 0x001b5740, r7   = 0x00000000
r8   = 0x001b9d48, r9   = 0xbecfeac4
r10  = 0x00000001, fp   = 0xbecfe8d8
ip   = 0xb41a1ce4, sp   = 0xbecfe0b0
lr   = 0xb3b27dab, pc   = 0xb3b419b4
cpsr = 0x680f0030

Memory Information
MemTotal:  2063912 KB
MemFree:   1170156 KB
Buffers:     30880 KB
Cached:     545980 KB
VmPeak:     121152 KB
VmSize:     117032 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26604 KB
VmRSS:       26604 KB
VmData:      16720 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       65980 KB
VmPTE:          98 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00070000 rw-p [heap]
00070000 00217000 rw-p [heap]
b05be000 b05c2000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b05cb000 b0dca000 rwxp [stack:5857]
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
b2e88000 b2ea3000 r-xp /opt/usr/apps/vMEuS5j7iC/bin/MyHondana.exe
b2eac000 b2ef4000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2efc000 b2f8c000 r-xp /usr/lib/libCOREGL.so.3.0
b2f96000 b2f99000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2fa1000 b2fa8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2fb1000 b2fc0000 r-xp /usr/lib/libICE.so.6.3.0
b2fca000 b2fcf000 r-xp /usr/lib/libSM.so.6.0.1
b2fd7000 b2fd8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2fe0000 b2fe2000 r-xp /usr/lib/libledplayer.so.0.1
b2fea000 b2ff0000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2ff8000 b2ff9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3002000 b3009000 r-xp /usr/lib/libGLESv2.so.2.0
b3011000 b3058000 r-xp /usr/lib/libtiff.so.5.1.0
b3063000 b308c000 r-xp /usr/lib/libturbojpeg.so
b30a5000 b30a9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b30b2000 b30b8000 r-xp /usr/lib/libgif.so.4.1.6
b30c0000 b30e2000 r-xp /usr/lib/libavutil.so.51.73.101
b30f1000 b311f000 r-xp /usr/lib/libswscale.so.2.1.101
b3128000 b341f000 r-xp /usr/lib/libavcodec.so.54.59.100
b3746000 b375f000 r-xp /usr/lib/libpng12.so.0.50.0
b3768000 b376f000 r-xp /usr/lib/libfeedback.so.0.1.4
b3778000 b378b000 r-xp /usr/lib/libtts.so
b3793000 b3795000 r-xp /usr/lib/libEGL.so.1.4
b379d000 b3854000 r-xp /usr/lib/libcairo.so.2.11200.12
b385e000 b3877000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3881000 b3886000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b388e000 b3890000 r-xp /opt/usr/apps/vMEuS5j7iC/bin/MyHondana
b3898000 b413a000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b41aa000 b41b3000 r-xp /usr/lib/libslp_devman_plugin.so
b41bc000 b41be000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b41c6000 b41c9000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b41d1000 b41d4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b41dc000 b41e9000 r-xp /usr/lib/libmodem.so.0.0.0
b41f1000 b41f4000 r-xp /usr/lib/libdevice-node.so.0.1
b41fc000 b420c000 r-xp /usr/lib/libaccounts-svc.so.0.2.68
b4214000 b4217000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b421f000 b422a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4232000 b4239000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4242000 b4247000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b424f000 b4250000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b4259000 b425c000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b4264000 b4269000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b4271000 b4274000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b427c000 b427d000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b4285000 b4293000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b429c000 b42a2000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b42aa000 b42cf000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b42d7000 b42da000 r-xp /usr/lib/libuuid.so.1.3.0
b42e3000 b42f7000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b42ff000 b4300000 r-xp /usr/lib/libpmapi.so.1.2
b4308000 b4310000 r-xp /usr/lib/libminizip.so.1.0.0
b4318000 b4324000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b432d000 b434b000 r-xp /usr/lib/libpcre.so.0.0.1
b4353000 b4357000 r-xp /usr/lib/libheynoti.so.0.0.2
b435f000 b436d000 r-xp /usr/lib/libdeviced.so.0.1.0
b4376000 b4381000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b438e000 b4397000 r-xp /usr/lib/libdevman.so.0.1
b439f000 b43a3000 r-xp /usr/lib/libchromium.so.1.0
b43ab000 b43b2000 r-xp /usr/lib/libalarm.so.0.0.0
b43ba000 b46c7000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b46ef000 b46f9000 r-xp /lib/libnss_files-2.13.so
b4709000 b4719000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.3
b471a000 b472d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b4735000 b4752000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b475a000 b475d000 r-xp /usr/lib/libiniparser.so.0
b4766000 b47b6000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b47c0000 b47d4000 r-xp /usr/lib/libcom-core.so.0.0.1
b47dc000 b47e2000 r-xp /usr/lib/libappsvc.so.0.1.0
b47ea000 b47ec000 r-xp /usr/lib/libdri2.so.0.0.0
b47f4000 b47fc000 r-xp /usr/lib/libdrm.so.2.4.0
b4804000 b4808000 r-xp /usr/lib/libtbm.so.1.0.0
b4810000 b4813000 r-xp /usr/lib/libXv.so.1.0.0
b481b000 b48e7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b48fd000 b490c000 r-xp /usr/lib/libnotification.so.0.1.0
b4914000 b4938000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4941000 b4951000 r-xp /lib/libresolv-2.13.so
b4955000 b4957000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b495f000 b4a37000 r-xp /usr/lib/libxml2.so.2.7.8
b4a44000 b4b21000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4b2c000 b4b31000 r-xp /usr/lib/libcheck.so.0.0.0
b4b39000 b4b43000 r-xp /usr/lib/libspdy.so.0.0.0
b4b4c000 b4c9f000 r-xp /usr/lib/libcrypto.so.1.0.0
b4cbd000 b4d09000 r-xp /usr/lib/libssl.so.1.0.0
b4d15000 b4d43000 r-xp /usr/lib/libidn.so.11.5.44
b4d4c000 b4d56000 r-xp /usr/lib/libcares.so.2.1.0
b4d5e000 b4d75000 r-xp /lib/libexpat.so.1.5.2
b4d7f000 b4da3000 r-xp /usr/lib/libicule.so.48.1
b4dac000 b4dba000 r-xp /usr/lib/libsf_common.so
b4dc3000 b4e5e000 r-xp /usr/lib/libstdc++.so.6.0.14
b4e71000 b4e89000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4e8a000 b4e8d000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4e95000 b4e99000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4ea2000 b4ea7000 r-xp /usr/lib/libffi.so.5.0.10
b4eaf000 b4eb0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4eb8000 b4ec2000 r-xp /usr/lib/libXext.so.6.4.0
b4ecb000 b4ece000 r-xp /usr/lib/libXtst.so.6.1.0
b4ed6000 b4edc000 r-xp /usr/lib/libXrender.so.1.3.0
b4ee4000 b4eea000 r-xp /usr/lib/libXrandr.so.2.2.0
b4ef2000 b4ef3000 r-xp /usr/lib/libXinerama.so.1.0.0
b4efc000 b4f05000 r-xp /usr/lib/libXi.so.6.1.0
b4f0d000 b4f10000 r-xp /usr/lib/libXfixes.so.3.1.0
b4f18000 b4f1a000 r-xp /usr/lib/libXgesture.so.7.0.0
b4f22000 b4f23000 r-xp /usr/lib/libXdamage.so.1.1.0
b4f2c000 b4f33000 r-xp /usr/lib/libXcursor.so.1.0.2
b4f3b000 b4f5e000 r-xp /usr/lib/libexif.so.12.3.3
b4f72000 b4f7c000 r-xp /usr/lib/libethumb.so.1.7.99
b4f84000 b4fc8000 r-xp /usr/lib/libsndfile.so.1.0.25
b4fd6000 b4fd8000 r-xp /usr/lib/libctxdata.so.0.0.0
b4fe0000 b4fee000 r-xp /usr/lib/libremix.so.0.0.0
b4ff6000 b4ff7000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4fff000 b5018000 r-xp /usr/lib/liblua-5.1.so
b5021000 b5028000 r-xp /usr/lib/libembryo.so.1.7.99
b5031000 b5071000 r-xp /usr/lib/libcurl.so.4.3.0
b507a000 b50e4000 r-xp /usr/lib/libpixman-1.so.0.28.2
b50f1000 b5115000 r-xp /usr/lib/libfontconfig.so.1.5.0
b511e000 b517a000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b518c000 b51a0000 r-xp /usr/lib/libfribidi.so.0.3.1
b51a8000 b5200000 r-xp /usr/lib/libfreetype.so.6.8.1
b520b000 b522f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5247000 b525e000 r-xp /lib/libz.so.1.2.5
b5266000 b526e000 r-xp /usr/lib/libemotion.so.1.7.99
b5276000 b527b000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5284000 b5292000 r-xp /usr/lib/libsensor.so.1.1.0
b529e000 b52a4000 r-xp /usr/lib/libappcore-common.so.1.1
b52ac000 b52ae000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.78
b52b6000 b52bf000 r-xp /usr/lib/libresourced.so.0.2.78
b52c8000 b52cb000 r-xp /usr/lib/libproc-stat.so.0.2.78
b62c8000 b63b0000 r-xp /usr/lib/libicuuc.so.48.1
b63bd000 b64dd000 r-xp /usr/lib/libicui18n.so.48.1
b64eb000 b64ee000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b64f6000 b64ff000 r-xp /usr/lib/libvconf.so.0.2.45
b6507000 b650d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6515000 b6521000 r-xp /usr/lib/libail.so.0.1.0
b6529000 b6534000 r-xp /usr/lib/libaul.so.0.1.0
b653c000 b6553000 r-xp /usr/lib/libecore_input.so.1.7.99
b656e000 b658b000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6594000 b6596000 r-xp /usr/lib/libXcomposite.so.1.0.0
b659e000 b65d2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b65db000 b660a000 r-xp /usr/lib/libecore_x.so.1.7.99
b6614000 b6653000 r-xp /usr/lib/libeina.so.1.7.99
b665c000 b6671000 r-xp /usr/lib/libecore.so.1.7.99
b6688000 b66a3000 r-xp /usr/lib/libecore_con.so.1.7.99
b66ac000 b66b1000 r-xp /usr/lib/libecore_imf.so.1.7.99
b66b9000 b66c1000 r-xp /usr/lib/libethumb_client.so.1.7.99
b66c9000 b66d2000 r-xp /usr/lib/libedbus.so.1.7.99
b66da000 b66dc000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b66e4000 b66e8000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b66f1000 b6707000 r-xp /usr/lib/libefreet.so.1.7.99
b6711000 b676d000 r-xp /usr/lib/libedje.so.1.7.99
b6777000 b6827000 r-xp /usr/lib/libevas.so.1.7.99
b6849000 b685c000 r-xp /usr/lib/libeet.so.1.7.99
b6865000 b68cf000 r-xp /lib/libm-2.13.so
b68d8000 b68e0000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.2
b68e1000 b68e8000 r-xp /usr/lib/libutilX.so.1.1.0
b68f0000 b6a12000 r-xp /usr/lib/libelementary.so.1.7.99
b6a27000 b6a2a000 r-xp /lib/libattr.so.1.1.0
b6a32000 b6a34000 r-xp /usr/lib/libXau.so.6.0.0
b6a3c000 b6a42000 r-xp /lib/librt-2.13.so
b6a4b000 b6a53000 r-xp /lib/libcrypt-2.13.so
b6a83000 b6a86000 r-xp /lib/libcap.so.2.21
b6a8e000 b6a90000 r-xp /usr/lib/libiri.so
b6a98000 b6aad000 r-xp /usr/lib/libxcb.so.1.1.0
b6ab5000 b6ac0000 r-xp /lib/libunwind.so.8.0.1
b6aee000 b6c0b000 r-xp /lib/libc-2.13.so
b6c19000 b6c22000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c2a000 b6c56000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c5f000 b6c62000 r-xp /usr/lib/libbundle.so.0.1.22
b6c6a000 b6c6c000 r-xp /lib/libdl-2.13.so
b6c75000 b6c78000 r-xp /usr/lib/libsmack.so.1.0.0
b6c80000 b6d5a000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d63000 b6d77000 r-xp /lib/libpthread-2.13.so
b6d83000 b6d88000 r-xp /usr/lib/libecore_file.so.1.7.99
b6d90000 b6d98000 r-xp /usr/lib/libappcore-efl.so.1.1
b6d9a000 b6d9b000 r-xp /usr/lib/libdlog.so.0.0.0
b6da4000 b6e11000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e1b000 b6e24000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e2c000 b6f12000 r-xp /usr/lib/libX11.so.6.3.0
b6f1d000 b6f1e000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f26000 b6f2a000 r-xp /usr/lib/libsys-assert.so
b6f32000 b6f4f000 r-xp /lib/ld-2.13.so
bece1000 bed02000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5855)
Call Stack Count: 36
 0: Tizen::Ui::_ControlImpl::GetFullScreenSizeInfo() + 0x53 (0xb3b419b4) [/usr/lib/osp/libosp-uifw.so] + 0x2a99b4
 1: Tizen::Ui::Control::AddTouchEventListener(Tizen::Ui::ITouchEventListener&) + 0xa (0xb3b27dab) [/usr/lib/osp/libosp-uifw.so] + 0x28fdab
 2: MyHondanaMainForm::SetCoverFlowView() + 0x98 (0xb2e98814) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0x10814
 3: MyHondanaMainForm::SetSplitPanel() + 0x1bc (0xb2e96ea8) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0xeea8
 4: MyHondanaMainForm::OnInitializing() + 0x6c (0xb2e96a14) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0xea14
 5: Tizen::Ui::_ControlImpl::OnAttachedToMainTree() + 0x22 (0xb3b42563) [/usr/lib/osp/libosp-uifw.so] + 0x2aa563
 6: Tizen::Ui::Controls::_FormImpl::OnAttachedToMainTree() + 0x28 (0xb3cfa6c9) [/usr/lib/osp/libosp-uifw.so] + 0x4626c9
 7: Tizen::Ui::_Control::CallOnAttachedToMainTree(Tizen::Ui::_Control&) + 0xb2 (0xb3b2adbf) [/usr/lib/osp/libosp-uifw.so] + 0x292dbf
 8: Tizen::Ui::_Control::EndAttaching(Tizen::Ui::_Control&) + 0xec (0xb3b2df19) [/usr/lib/osp/libosp-uifw.so] + 0x295f19
 9: Tizen::Ui::_Control::AttachChild(Tizen::Ui::_Control&) + 0x5a (0xb3b3090b) [/usr/lib/osp/libosp-uifw.so] + 0x29890b
10: Tizen::Ui::_ContainerImpl::AddChild(Tizen::Ui::_ControlImpl*, bool) + 0xa4 (0xb3b4da6d) [/usr/lib/osp/libosp-uifw.so] + 0x2b5a6d
11: Tizen::Ui::Container::AddControl(Tizen::Ui::Control*) + 0x26 (0xb3b2517b) [/usr/lib/osp/libosp-uifw.so] + 0x28d17b
12: Tizen::Ui::Container::AddControl(Tizen::Ui::Control const&) + 0x6 (0xb3b25207) [/usr/lib/osp/libosp-uifw.so] + 0x28d207
13: (0xb3dc2b57) [/usr/lib/osp/libosp-uifw.so] + 0x52ab57
14: (0xb3dc349f) [/usr/lib/osp/libosp-uifw.so] + 0x52b49f
15: (0xb3dc601d) [/usr/lib/osp/libosp-uifw.so] + 0x52e01d
16: Tizen::Ui::Scenes::SceneManager::GoForward(Tizen::Ui::Scenes::ForwardSceneTransition const&, Tizen::Base::Collection::IList const*) + 0x18 (0xb3dbab25) [/usr/lib/osp/libosp-uifw.so] + 0x522b25
17: MyHondanaFrame::OnInitializing() + 0x64 (0xb2e9598c) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0xd98c
18: Tizen::Ui::_ControlImpl::OnAttachedToMainTree() + 0x22 (0xb3b42563) [/usr/lib/osp/libosp-uifw.so] + 0x2aa563
19: Tizen::Ui::Controls::_FrameImpl::OnAttachedToMainTree() + 0xa (0xb3cfd5e7) [/usr/lib/osp/libosp-uifw.so] + 0x4655e7
20: Tizen::Ui::_ControlManager::CallOnAttachedToMainTree(Tizen::Ui::_Control&) + 0x76 (0xb3b518c7) [/usr/lib/osp/libosp-uifw.so] + 0x2b98c7
21: Tizen::Ui::_ControlManager::ActivateWindow(Tizen::Ui::_Window&, bool) + 0xcc (0xb3b522f5) [/usr/lib/osp/libosp-uifw.so] + 0x2ba2f5
22: Tizen::Ui::_ControlManager::OpenWindow(Tizen::Ui::_Window&, bool) + 0x2e (0xb3b52507) [/usr/lib/osp/libosp-uifw.so] + 0x2ba507
23: Tizen::Ui::_Window::Open(bool) + 0x3c (0xb3b3f821) [/usr/lib/osp/libosp-uifw.so] + 0x2a7821
24: Tizen::Ui::_WindowImpl::Open(bool) + 0x12 (0xb3b4f897) [/usr/lib/osp/libosp-uifw.so] + 0x2b7897
25: Tizen::App::_UiAppImpl::AddFrame(Tizen::Ui::Controls::Frame const&) + 0x40 (0xb3ef7f35) [/usr/lib/osp/libosp-uifw.so] + 0x65ff35
26: Tizen::App::UiApp::AddFrame(Tizen::Ui::Controls::Frame const&) + 0x14 (0xb3ef72f9) [/usr/lib/osp/libosp-uifw.so] + 0x65f2f9
27: MyHondanaApp::OnAppInitialized() + 0x88 (0xb2e9339c) [/opt/apps/vMEuS5j7iC/bin/MyHondana.exe] + 0xb39c
28: Tizen::App::_UiAppImpl::OnAppInitialized() + 0x18 (0xb3ef77dd) [/usr/lib/osp/libosp-uifw.so] + 0x65f7dd
29: Tizen::App::_AppImpl::OnService(service_s*, void*) + 0x1da (0xb44aa39f) [/usr/lib/osp/libosp-appfw.so] + 0xf039f
30: (0xb428ebdd) [/usr/lib/libcapi-appfw-application.so.0] + 0x9bdd
31: (0xb6d92f28) [/usr/lib/libappcore-efl.so.1] + 0x2f28
32: (0xb529f94c) [/usr/lib/libappcore-common.so.1] + 0x194c
33: (0xb52a0024) [/usr/lib/libappcore-common.so.1] + 0x2024
34: (0xb652c1a9) [/usr/lib/libaul.so.0] + 0x31a9
dladdr failed 35: (0x81a38) (null)
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
